namespace System.IO;

internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	private Byte[] _array; //Field offset: 0x68
	private GCHandle _pinningHandle; //Field offset: 0x70

	internal PinnedBufferMemoryStream(Byte[] array) { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public virtual int Read(Span<Byte> buffer) { }

	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

}

