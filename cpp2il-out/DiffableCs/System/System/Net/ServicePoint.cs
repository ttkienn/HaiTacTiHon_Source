namespace System.Net;

public class ServicePoint
{
	private readonly Uri uri; //Field offset: 0x10
	private DateTime lastDnsResolve; //Field offset: 0x18
	private Version protocolVersion; //Field offset: 0x20
	private IPHostEntry host; //Field offset: 0x28
	private bool usesProxy; //Field offset: 0x30
	private bool sendContinue; //Field offset: 0x31
	private bool useConnect; //Field offset: 0x32
	private object hostE; //Field offset: 0x38
	private bool useNagle; //Field offset: 0x40
	private BindIPEndPoint endPointCallback; //Field offset: 0x48
	private bool tcp_keepalive; //Field offset: 0x50
	private int tcp_keepalive_time; //Field offset: 0x54
	private int tcp_keepalive_interval; //Field offset: 0x58
	private bool disposed; //Field offset: 0x5C
	private int connectionLeaseTimeout; //Field offset: 0x60
	private int receiveBufferSize; //Field offset: 0x64
	[CompilerGenerated]
	private readonly SPKey <Key>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; //Field offset: 0x70
	private int connectionLimit; //Field offset: 0x78
	private int maxIdleTime; //Field offset: 0x7C
	private object m_ServerCertificateOrBytes; //Field offset: 0x80
	private object m_ClientCertificateOrBytes; //Field offset: 0x88

	public Uri Address
	{
		 get { } //Length: 5
	}

	public int ConnectionLimit
	{
		 get { } //Length: 4
	}

	public bool Expect100Continue
	{
		 set { } //Length: 4
	}

	private bool HasTimedOut
	{
		private get { } //Length: 282
	}

	internal IPHostEntry HostEntry
	{
		internal get { } //Length: 1108
	}

	internal SPKey Key
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public override Version ProtocolVersion
	{
		 get { } //Length: 5
	}

	private ServicePointScheduler Scheduler
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal bool SendContinue
	{
		internal get { } //Length: 139
		internal set { } //Length: 4
	}

	internal bool UseConnect
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	public bool UseNagleAlgorithm
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal bool UsesProxy
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal ServicePoint(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	internal void FreeServicePoint() { }

	public Uri get_Address() { }

	public int get_ConnectionLimit() { }

	private bool get_HasTimedOut() { }

	internal IPHostEntry get_HostEntry() { }

	[CompilerGenerated]
	internal SPKey get_Key() { }

	public override Version get_ProtocolVersion() { }

	[CompilerGenerated]
	private ServicePointScheduler get_Scheduler() { }

	internal bool get_SendContinue() { }

	internal bool get_UseConnect() { }

	public bool get_UseNagleAlgorithm() { }

	internal bool get_UsesProxy() { }

	internal void KeepAliveSetup(Socket socket) { }

	private static void PutBytes(Byte[] bytes, uint v, int offset) { }

	internal void SendRequest(WebOperation operation, string groupName) { }

	public void set_Expect100Continue(bool value) { }

	[CompilerGenerated]
	private void set_Scheduler(ServicePointScheduler value) { }

	internal void set_SendContinue(bool value) { }

	internal void set_UseConnect(bool value) { }

	public void set_UseNagleAlgorithm(bool value) { }

	internal void set_UsesProxy(bool value) { }

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	internal void SetVersion(Version version) { }

	internal void UpdateClientCertificate(X509Certificate certificate) { }

	internal void UpdateServerCertificate(X509Certificate certificate) { }

}

