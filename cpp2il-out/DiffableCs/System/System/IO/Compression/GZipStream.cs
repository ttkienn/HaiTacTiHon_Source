namespace System.IO.Compression;

public class GZipStream : Stream
{
	private DeflateStream _deflateStream; //Field offset: 0x28

	public virtual bool CanRead
	{
		 get { } //Length: 32
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 32
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 32
	}

	public virtual long Length
	{
		 get { } //Length: 78
	}

	public virtual long Position
	{
		 get { } //Length: 78
		 set { } //Length: 78
	}

	public GZipStream(Stream stream, CompressionMode mode) { }

	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	private void CheckDeflateStream() { }

	public virtual void CopyTo(Stream destination, int bufferSize) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] array, int offset, int count) { }

	public virtual int Read(Span<Byte> buffer) { }

	public virtual Task<Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private static void ThrowStreamClosedException() { }

	public virtual void Write(Byte[] array, int offset, int count) { }

	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	public virtual Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

}

