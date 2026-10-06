namespace System.Net;

internal abstract class WebConnectionStream : Stream
{
	protected bool closed; //Field offset: 0x28
	private bool disposed; //Field offset: 0x29
	private object locker; //Field offset: 0x30
	private int read_timeout; //Field offset: 0x38
	private int write_timeout; //Field offset: 0x3C
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; //Field offset: 0x50

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 3
	}

	internal WebConnection Connection
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public virtual long Length
	{
		 get { } //Length: 78
	}

	internal WebOperation Operation
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 78
		 set { } //Length: 78
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	internal HttpWebRequest Request
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ServicePoint ServicePoint
	{
		internal get { } //Length: 27
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	protected WebConnectionStream(WebConnection cnc, WebOperation operation) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	public virtual void Close() { }

	protected abstract void Close_internal(ref bool disposed) { }

	public virtual int EndRead(IAsyncResult r) { }

	public virtual void EndWrite(IAsyncResult r) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	[CompilerGenerated]
	internal WebConnection get_Connection() { }

	public virtual long get_Length() { }

	[CompilerGenerated]
	internal WebOperation get_Operation() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	[CompilerGenerated]
	internal HttpWebRequest get_Request() { }

	internal ServicePoint get_ServicePoint() { }

	public virtual int get_WriteTimeout() { }

	protected Exception GetException(Exception e) { }

	internal void InternalClose() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long a, SeekOrigin b) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	public virtual void SetLength(long a) { }

	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

