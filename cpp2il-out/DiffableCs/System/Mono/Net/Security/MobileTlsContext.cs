namespace Mono.Net.Security;

internal abstract class MobileTlsContext : IDisposable
{
	private ChainValidationHelper certificateValidator; //Field offset: 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; //Field offset: 0x50

	protected bool AskForClientCertificate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected X509CertificateCollection ClientCertificates
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected SslProtocols EnabledProtocols
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public abstract bool IsAuthenticated
	{
		 get { } //Length: 0
	}

	public bool IsServer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal abstract X509Certificate LocalClientCertificate
	{
		internal get { } //Length: 0
	}

	internal X509Certificate LocalServerCertificate
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal MonoSslAuthenticationOptions Options
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal MobileAuthenticatedStream Parent
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public abstract X509Certificate2 RemoteCertificate
	{
		 get { } //Length: 0
	}

	protected string ServerName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MonoTlsSettings Settings
	{
		 get { } //Length: 30
	}

	internal string TargetHost
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public abstract void FinishHandshake() { }

	public abstract void Flush() { }

	[CompilerGenerated]
	protected bool get_AskForClientCertificate() { }

	[CompilerGenerated]
	protected X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	protected SslProtocols get_EnabledProtocols() { }

	public abstract bool get_IsAuthenticated() { }

	[CompilerGenerated]
	public bool get_IsServer() { }

	internal abstract X509Certificate get_LocalClientCertificate() { }

	[CompilerGenerated]
	internal X509Certificate get_LocalServerCertificate() { }

	[CompilerGenerated]
	internal MonoSslAuthenticationOptions get_Options() { }

	[CompilerGenerated]
	internal MobileAuthenticatedStream get_Parent() { }

	public abstract X509Certificate2 get_RemoteCertificate() { }

	[CompilerGenerated]
	protected string get_ServerName() { }

	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	internal string get_TargetHost() { }

	protected void GetProtocolVersions(out Nullable<TlsProtocolCode>& min, out Nullable<TlsProtocolCode>& max) { }

	public abstract bool PendingRenegotiation() { }

	public abstract bool ProcessHandshake() { }

	public abstract ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	public abstract void Renegotiate() { }

	protected X509Certificate SelectClientCertificate(String[] acceptableIssuers) { }

	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	[CompilerGenerated]
	private void set_LocalServerCertificate(X509Certificate value) { }

	public abstract void Shutdown() { }

	public abstract void StartHandshake() { }

	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	public abstract ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

}

