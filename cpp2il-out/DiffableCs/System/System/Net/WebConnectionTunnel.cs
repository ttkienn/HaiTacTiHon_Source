namespace System.Net;

internal class WebConnectionTunnel
{
	[CompilerGenerated]
	private struct <Initialize>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebConnectionTunnel <>4__this; //Field offset: 0x20
		public Stream stream; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private bool <have_auth>5__2; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, Byte[], Int32>> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadHeaders>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`3<WebHeaderCollection, Byte[], Int32>> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Stream stream; //Field offset: 0x28
		public WebConnectionTunnel <>4__this; //Field offset: 0x30
		private Byte[] <retBuffer>5__2; //Field offset: 0x38
		private int <status>5__3; //Field offset: 0x40
		private Byte[] <buffer>5__4; //Field offset: 0x48
		private MemoryStream <ms>5__5; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; //Field offset: 0x18
	private HttpWebRequest connectRequest; //Field offset: 0x20
	private NtlmAuthState ntlmAuthState; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private String[] <Challenge>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Byte[] <Data>k__BackingField; //Field offset: 0x58

	public private String[] Challenge
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private bool CloseConnection
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Uri ConnectUri
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private Byte[] Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private WebHeaderCollection Headers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private Version ProxyVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public HttpWebRequest Request
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private int StatusCode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private string StatusDescription
	{
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private bool Success
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public WebConnectionTunnel(HttpWebRequest request, Uri connectUri) { }

	private void FlushContents(Stream stream, int contentLength) { }

	[CompilerGenerated]
	public String[] get_Challenge() { }

	[CompilerGenerated]
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	public Uri get_ConnectUri() { }

	[CompilerGenerated]
	public Byte[] get_Data() { }

	[CompilerGenerated]
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	public int get_StatusCode() { }

	[CompilerGenerated]
	public bool get_Success() { }

	[AsyncStateMachine(typeof(<Initialize>d__42))]
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadHeaders>d__43))]
	private Task<ValueTuple`3<WebHeaderCollection, Byte[], Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private void set_Challenge(String[] value) { }

	[CompilerGenerated]
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	private void set_Data(Byte[] value) { }

	[CompilerGenerated]
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	private void set_Success(bool value) { }

}

