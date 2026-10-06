namespace System.Net;

internal class WebResponseStream : WebConnectionStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public WebResponseStream <>4__this; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x18
		public int offset; //Field offset: 0x20
		public int size; //Field offset: 0x24

		public <>c__DisplayClass41_0() { }

		internal Task<Int32> <ProcessRead>b__0(CancellationToken ct) { }

		internal void <ProcessRead>b__1() { }

		internal bool <ProcessRead>b__2() { }

	}

	[CompilerGenerated]
	private struct <InitReadAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebResponseStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		private ReadState <state>5__3; //Field offset: 0x38
		private int <position>5__4; //Field offset: 0x3C
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebResponseStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool resending; //Field offset: 0x30
		private WebCompletionSource <completion>5__2; //Field offset: 0x38
		private CancellationTokenSource <timeoutCts>5__3; //Field offset: 0x40
		private Task <timeoutTask>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Byte[]> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WebResponseStream <>4__this; //Field offset: 0x28
		private long <maximumSize>5__2; //Field offset: 0x30
		private MemoryStream <ms>5__3; //Field offset: 0x38
		private Byte[] <buffer>5__4; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		public int offset; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public WebResponseStream <>4__this; //Field offset: 0x38
		private WebCompletionSource <completion>5__2; //Field offset: 0x40
		private int <nbytes>5__3; //Field offset: 0x48
		private Exception <throwMe>5__4; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x58
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private WebReadStream innerStream; //Field offset: 0x58
	private bool nextReadCalled; //Field offset: 0x60
	private bool bufferedEntireContent; //Field offset: 0x61
	private WebCompletionSource pendingRead; //Field offset: 0x68
	private object locker; //Field offset: 0x70
	private int nestedRead; //Field offset: 0x78
	private bool read_eof; //Field offset: 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; //Field offset: 0xA9

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	private bool ChunkedRead
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool ExpectContent
	{
		private get { } //Length: 2142
	}

	public private WebHeaderCollection Headers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private bool KeepAlive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public WebRequestStream RequestStream
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private HttpStatusCode StatusCode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private string StatusDescription
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Version Version
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public WebResponseStream(WebRequestStream request) { }

	protected virtual void Close_internal(ref bool disposed) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	private bool get_ChunkedRead() { }

	private bool get_ExpectContent() { }

	[CompilerGenerated]
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	public string get_StatusDescription() { }

	[CompilerGenerated]
	public Version get_Version() { }

	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(<InitReadAsync>d__52))]
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	private Task<Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAllAsync>d__48))]
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAllAsyncInner>d__47))]
	private Task<Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAsync>d__40))]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private void set_ChunkedRead(bool value) { }

	[CompilerGenerated]
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	private void set_KeepAlive(bool value) { }

	[CompilerGenerated]
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	private void set_Version(Version value) { }

	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

