namespace System.Net;

internal class NetworkStreamWrapper : Stream
{
	private TcpClient _client; //Field offset: 0x28
	private NetworkStream _networkStream; //Field offset: 0x30

	public virtual bool CanRead
	{
		 get { } //Length: 42
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 42
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 42
	}

	public virtual long Length
	{
		 get { } //Length: 42
	}

	internal NetworkStream NetworkStream
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public virtual long Position
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	internal IPAddress ServerAddress
	{
		internal get { } //Length: 138
	}

	internal Socket Socket
	{
		internal get { } //Length: 27
	}

	protected bool UsingSecureStream
	{
		 get { } //Length: 130
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	internal NetworkStreamWrapper(TcpClient client) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public void Close(int timeout) { }

	internal void CloseSocket() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	internal NetworkStream get_NetworkStream() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	internal IPAddress get_ServerAddress() { }

	internal Socket get_Socket() { }

	protected bool get_UsingSecureStream() { }

	public virtual int get_WriteTimeout() { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	internal void set_NetworkStream(NetworkStream value) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	public virtual void SetLength(long value) { }

	internal void SetSocketTimeoutOption(int timeout) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

