namespace Mono.Net.Security;

internal abstract class MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; //Field offset: 0x10

	public abstract bool AllowRenegotiation
	{
		 get { } //Length: 0
	}

	public abstract X509RevocationMode CertificateRevocationCheckMode
	{
		 set { } //Length: 0
	}

	public abstract bool ClientCertificateRequired
	{
		 get { } //Length: 0
	}

	public abstract X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract SslProtocols EnabledSslProtocols
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract EncryptionPolicy EncryptionPolicy
	{
		 set { } //Length: 0
	}

	public abstract X509Certificate ServerCertificate
	{
		 get { } //Length: 0
	}

	internal ServerCertSelectionCallback ServerCertSelectionDelegate
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public abstract bool ServerMode
	{
		 get { } //Length: 0
	}

	public abstract string TargetHost
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected MonoSslAuthenticationOptions() { }

	public abstract bool get_AllowRenegotiation() { }

	public abstract bool get_ClientCertificateRequired() { }

	public abstract X509CertificateCollection get_ClientCertificates() { }

	public abstract SslProtocols get_EnabledSslProtocols() { }

	public abstract X509Certificate get_ServerCertificate() { }

	[CompilerGenerated]
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	public abstract bool get_ServerMode() { }

	public abstract string get_TargetHost() { }

	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	public abstract void set_ClientCertificates(X509CertificateCollection value) { }

	public abstract void set_EnabledSslProtocols(SslProtocols value) { }

	public abstract void set_EncryptionPolicy(EncryptionPolicy value) { }

	public abstract void set_TargetHost(string value) { }

}

