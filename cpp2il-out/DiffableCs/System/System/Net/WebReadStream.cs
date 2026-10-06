namespace System.Net;

internal abstract class WebReadStream : Stream
{
	[CompilerGenerated]
	private struct <ReadAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public WebReadStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Byte[] buffer; //Field offset: 0x30
		public int offset; //Field offset: 0x38
		public int size; //Field offset: 0x3C
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0x30
	private bool disposed; //Field offset: 0x38

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	protected Stream InnerStream
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual long Length
	{
		 get { } //Length: 62
	}

	public WebOperation Operation
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	public WebReadStream(WebOperation operation, Stream innerStream) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult r) { }

	internal override Task FinishReading(CancellationToken cancellationToken) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	protected Stream get_InnerStream() { }

	public virtual long get_Length() { }

	[CompilerGenerated]
	public WebOperation get_Operation() { }

	public virtual long get_Position() { }

	protected Exception GetException(Exception e) { }

	protected abstract Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(<ReadAsync>d__28))]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

