namespace System.Net;

internal class WebOperation
{
	[CompilerGenerated]
	private struct <Run>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public WebOperation <>4__this; //Field offset: 0x28
		private WebRequestStream <requestStream>5__2; //Field offset: 0x30
		private WebResponseStream <stream>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; //Field offset: 0x30
	private CancellationTokenSource cts; //Field offset: 0x38
	private WebCompletionSource<WebRequestStream> requestTask; //Field offset: 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; //Field offset: 0x48
	private WebCompletionSource<WebResponseStream> responseTask; //Field offset: 0x50
	private WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> finishedTask; //Field offset: 0x58
	private WebRequestStream writeStream; //Field offset: 0x60
	private WebResponseStream responseStream; //Field offset: 0x68
	private ExceptionDispatchInfo disposedInfo; //Field offset: 0x70
	private ExceptionDispatchInfo closedInfo; //Field offset: 0x78
	private WebOperation priorityRequest; //Field offset: 0x80
	private int requestSent; //Field offset: 0x88
	private int finished; //Field offset: 0x8C

	public bool Aborted
	{
		 get { } //Length: 79
	}

	public bool Closed
	{
		 get { } //Length: 85
	}

	public private WebConnection Connection
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> Finished
	{
		internal get { } //Length: 5
	}

	public bool IsNtlmChallenge
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HttpWebRequest Request
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private ServicePoint ServicePoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public BufferOffsetSize WriteBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public WebRequestStream WriteStream
	{
		 get { } //Length: 89
	}

	public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private void <RegisterRequest>b__48_0() { }

	public void Abort() { }

	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	public void Close() { }

	internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null) { }

	internal void Finish(bool ok, Exception error = null) { }

	public bool get_Aborted() { }

	public bool get_Closed() { }

	[CompilerGenerated]
	public WebConnection get_Connection() { }

	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> get_Finished() { }

	[CompilerGenerated]
	public bool get_IsNtlmChallenge() { }

	[CompilerGenerated]
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	public BufferOffsetSize get_WriteBuffer() { }

	public WebRequestStream get_WriteStream() { }

	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	public Task<WebResponseStream> GetResponseStream() { }

	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	[AsyncStateMachine(typeof(<Run>d__58))]
	internal void Run() { }

	[CompilerGenerated]
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	private void set_ServicePoint(ServicePoint value) { }

	private void SetCanceled() { }

	private ValueTuple<ExceptionDispatchInfo, Boolean> SetDisposed(ref ExceptionDispatchInfo field) { }

	private void SetError(Exception error) { }

	public void SetPriorityRequest(WebOperation operation) { }

	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	internal void ThrowIfClosedOrDisposed() { }

	internal void ThrowIfDisposed() { }

	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

}

