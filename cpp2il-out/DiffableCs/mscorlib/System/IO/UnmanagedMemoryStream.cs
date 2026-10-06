namespace System.IO;

public class UnmanagedMemoryStream : Stream
{
	private SafeBuffer _buffer; //Field offset: 0x28
	private Byte* _mem; //Field offset: 0x30
	private long _length; //Field offset: 0x38
	private long _capacity; //Field offset: 0x40
	private long _position; //Field offset: 0x48
	private long _offset; //Field offset: 0x50
	private FileAccess _access; //Field offset: 0x58
	internal bool _isOpen; //Field offset: 0x5C
	private Task<Int32> _lastReadTask; //Field offset: 0x60

	public virtual bool CanRead
	{
		 get { } //Length: 17
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 5
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 17
	}

	public virtual long Length
	{
		 get { } //Length: 68
	}

	public virtual long Position
	{
		 get { } //Length: 81
		 set { } //Length: 193
	}

	[CLSCompliant(False)]
	public Byte* PositionPointer
	{
		 get { } //Length: 232
	}

	protected UnmanagedMemoryStream() { }

	[CLSCompliant(False)]
	public UnmanagedMemoryStream(Byte* pointer, long length, long capacity, FileAccess access) { }

	protected virtual void Dispose(bool disposing) { }

	private void EnsureNotClosed() { }

	private void EnsureReadable() { }

	private void EnsureWriteable() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public Byte* get_PositionPointer() { }

	[CLSCompliant(False)]
	protected void Initialize(Byte* pointer, long length, long capacity, FileAccess access) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int Read(Span<Byte> buffer) { }

	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	internal int ReadCore(Span<Byte> buffer) { }

	public virtual long Seek(long offset, SeekOrigin loc) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual void WriteByte(byte value) { }

	internal void WriteCore(ReadOnlySpan<Byte> buffer) { }

}

