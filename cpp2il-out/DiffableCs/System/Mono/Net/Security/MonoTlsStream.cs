namespace Mono.Net.Security;

internal class MonoTlsStream : IDisposable
{
	[CompilerGenerated]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		public MonoTlsStream <>4__this; //Field offset: 0x20
		public WebConnectionTunnel tunnel; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private Socket <socket>5__2; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly MobileTlsProvider provider; //Field offset: 0x10
	private readonly NetworkStream networkStream; //Field offset: 0x18
	private readonly HttpWebRequest request; //Field offset: 0x20
	private readonly MonoTlsSettings settings; //Field offset: 0x28
	private SslStream sslStream; //Field offset: 0x30
	private readonly object sslStreamLock; //Field offset: 0x38
	private WebExceptionStatus status; //Field offset: 0x40
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0x44

	internal bool CertificateValidationFailed
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal WebExceptionStatus ExceptionStatus
	{
		internal get { } //Length: 4
	}

	internal HttpWebRequest Request
	{
		internal get { } //Length: 5
	}

	public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) { }

	private void CloseSslStream() { }

	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	public override void Dispose() { }

	[CompilerGenerated]
	internal bool get_CertificateValidationFailed() { }

	internal WebExceptionStatus get_ExceptionStatus() { }

	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	internal void set_CertificateValidationFailed(bool value) { }

}

