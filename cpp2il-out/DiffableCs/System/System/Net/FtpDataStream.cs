namespace System.Net;

internal class FtpDataStream : Stream, ICloseEx
{
	private FtpWebRequest _request; //Field offset: 0x28
	private NetworkStream _networkStream; //Field offset: 0x30
	private bool _writeable; //Field offset: 0x38
	private bool _readable; //Field offset: 0x39
	private bool _isFullyRead; //Field offset: 0x3A
	private bool _closing; //Field offset: 0x3B

	public virtual bool CanRead
	{
		 get { } //Length: 5
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
		 get { } //Length: 5
	}

	public virtual long Length
	{
		 get { } //Length: 42
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

	public virtual int WriteTimeout
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	private void AsyncReadCallback(IAsyncResult ar) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	private void CheckError() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult ar) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	public virtual void SetLength(long value) { }

	internal void SetSocketTimeoutOption(int timeout) { }

	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

