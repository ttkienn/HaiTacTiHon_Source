"""
Fix the data loading freeze at 377/378 by optimizing the oversized PNG file.
Uses zopfli or raw zlib recompression of PNG chunks for maximum compression.
"""
import struct, io, sys, shutil, zlib
from pathlib import Path

MAX_SIZE = 60000
DATA_DIR = Path(r"c:\Program Files\HaiTacTiHon\private-server\data\datafromsver\x2")

def read_data_file(filepath):
    raw = filepath.read_bytes()
    name_len = struct.unpack(">H", raw[0:2])[0]
    name = raw[2:2+name_len].decode("utf-8")
    png_data = raw[2+name_len:]
    return name, png_data

def write_data_file(filepath, name, png_data):
    name_bytes = name.encode("utf-8")
    out = struct.pack(">H", len(name_bytes)) + name_bytes + png_data
    filepath.write_bytes(out)

def parse_png_chunks(data):
    """Parse PNG file into signature + list of (type, data) chunks."""
    sig = data[:8]
    assert sig == b'\x89PNG\r\n\x1a\n', "Not a valid PNG"
    chunks = []
    pos = 8
    while pos < len(data):
        length = struct.unpack(">I", data[pos:pos+4])[0]
        chunk_type = data[pos+4:pos+8]
        chunk_data = data[pos+8:pos+8+length]
        crc = data[pos+8+length:pos+12+length]
        chunks.append((chunk_type, chunk_data, crc))
        pos += 12 + length
    return sig, chunks

def recompress_png(png_data):
    """Recompress PNG IDAT chunks with maximum zlib compression."""
    sig, chunks = parse_png_chunks(png_data)
    
    # Extract all IDAT data
    idat_data = b""
    for chunk_type, chunk_data, _ in chunks:
        if chunk_type == b"IDAT":
            idat_data += chunk_data
    
    # Decompress all IDAT data
    decompressed = zlib.decompress(idat_data)
    print(f"  Decompressed IDAT: {len(decompressed)} bytes")
    
    # Recompress with maximum compression
    best = None
    for level in [9]:
        for strategy in [zlib.Z_DEFAULT_STRATEGY, zlib.Z_FILTERED, zlib.Z_RLE]:
            for wbits in [15]:
                for memlevel in [9, 8]:
                    c = zlib.compressobj(level, zlib.DEFLATED, wbits, memlevel, strategy)
                    compressed = c.compress(decompressed) + c.flush()
                    if best is None or len(compressed) < len(best):
                        best = compressed
    
    print(f"  Best recompressed IDAT: {len(best)} bytes (original: {len(idat_data)} bytes)")
    
    # Rebuild PNG with single IDAT chunk
    out = bytearray(sig)
    for chunk_type, chunk_data, _ in chunks:
        if chunk_type == b"IDAT":
            continue  # skip original IDATs
        if chunk_type == b"IEND":
            # Write single IDAT before IEND
            idat_chunk = struct.pack(">I", len(best)) + b"IDAT" + best
            idat_crc = struct.pack(">I", zlib.crc32(b"IDAT" + best) & 0xFFFFFFFF)
            out += idat_chunk + idat_crc
        # Write non-IDAT chunk
        chunk_bytes = struct.pack(">I", len(chunk_data)) + chunk_type + chunk_data
        crc = struct.pack(">I", zlib.crc32(chunk_type + chunk_data) & 0xFFFFFFFF)
        out += chunk_bytes + crc
    
    return bytes(out)

def try_quantize_png(png_data, target_size):
    """Quantize PNG to reduce colors, using Pillow with proper RGBA method."""
    try:
        from PIL import Image
        img = Image.open(io.BytesIO(png_data))
        img = img.convert("RGBA")
        
        for colors in [256, 192, 128, 96, 64]:
            quantized = img.quantize(colors=colors, method=Image.Quantize.FASTOCTREE)
            quantized_rgba = quantized.convert("RGBA")
            
            # Save with Pillow first
            buf = io.BytesIO()
            quantized_rgba.save(buf, format="PNG", optimize=True, compress_level=9)
            result = buf.getvalue()
            
            # Then recompress with zlib for even better compression
            result = recompress_png(result)
            print(f"  Quantized to {colors} colors, recompressed: {len(result)} bytes")
            
            if len(result) <= target_size:
                return result
        
        return result
    except Exception as e:
        print(f"  Quantize failed: {e}")
        return None

def main():
    target = DATA_DIR / "0198_-39"
    if not target.exists():
        print(f"ERROR: {target} not found")
        sys.exit(1)

    name, png_data = read_data_file(target)
    total_file_size = target.stat().st_size
    header_size = 2 + len(name.encode("utf-8"))
    target_png_size = MAX_SIZE - header_size

    print(f"File: {target.name}")
    print(f"Image name: {name}")
    print(f"Original PNG size: {len(png_data)} bytes, total file: {total_file_size} bytes")
    print(f"Target PNG size: <= {target_png_size} bytes")
    print()

    if total_file_size <= MAX_SIZE:
        print("File is already small enough.")
        return

    # Step 1: Try recompression only
    print("Step 1: Recompressing with maximum zlib settings...")
    recompressed = recompress_png(png_data)
    print(f"  Result: {len(recompressed)} bytes")
    
    if len(recompressed) <= target_png_size:
        result = recompressed
    else:
        # Step 2: Try color quantization
        print()
        print("Step 2: Trying color quantization...")
        quantized = try_quantize_png(png_data, target_png_size)
        if quantized and len(quantized) <= target_png_size:
            result = quantized
        elif recompressed and len(recompressed) < len(png_data):
            result = recompressed
            print(f"\nWARNING: Could not achieve target size, using best: {len(result)} bytes")
        else:
            print("ERROR: Could not reduce file size at all!")
            return

    # Backup and write
    backup = target.with_suffix(".bak")
    if not backup.exists():
        shutil.copy2(target, backup)
        print(f"\nBackup: {backup.name}")

    write_data_file(target, name, result)
    new_total = target.stat().st_size
    print(f"\nDone!")
    print(f"  Original: {total_file_size:,} bytes")
    print(f"  New:      {new_total:,} bytes")
    print(f"  Saved:    {total_file_size - new_total:,} bytes ({(1 - new_total/total_file_size)*100:.1f}%)")
    
    if new_total <= MAX_SIZE:
        print(f"  ✓ Under {MAX_SIZE:,} byte limit")
    else:
        print(f"  ✗ Still over limit ({new_total - MAX_SIZE:,} bytes over)")

if __name__ == "__main__":
    main()
