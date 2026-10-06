namespace System.IO.Compression;

public class DeflateStream : Stream
{
	private sealed class ReadMethod : MulticastDelegate
	{

		public ReadMethod(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(Byte[] array, int offset, int count) { }

	}

	private sealed class WriteMethod : MulticastDelegate
	{

		public WriteMethod(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Byte[] array, int offset, int count) { }

	}

	private Stream base_stream; //Field offset: 0x28
	private CompressionMode mode; //Field offset: 0x30
	private bool leaveOpen; //Field offset: 0x34
	private bool disposed; //Field offset: 0x35
	private DeflateStreamNative native; //Field offset: 0x38

	public virtual bool CanRead
	{
		 get { } //Length: 61
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 61
	}

	public virtual long Length
	{
		 get { } //Length: 62
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	public DeflateStream(Stream stream, CompressionMode mode) { }

	internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] array, int offset, int count) { }

	internal ValueTask<Int32> ReadAsyncMemory(Memory<Byte> destination, CancellationToken cancellationToken) { }

	internal int ReadCore(Span<Byte> destination) { }

	private int ReadInternal(Byte[] array, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] array, int offset, int count) { }

	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<Byte> source, CancellationToken cancellationToken) { }

	internal void WriteCore(ReadOnlySpan<Byte> source) { }

	private void WriteInternal(Byte[] array, int offset, int count) { }

}

