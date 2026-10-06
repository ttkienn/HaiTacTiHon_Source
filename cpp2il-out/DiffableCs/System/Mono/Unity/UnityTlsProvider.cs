namespace Mono.Unity;

internal class UnityTlsProvider : MobileTlsProvider
{

	public virtual Guid ID
	{
		 get { } //Length: 91
	}

	public virtual string Name
	{
		 get { } //Length: 44
	}

	public virtual SslProtocols SupportedProtocols
	{
		 get { } //Length: 6
	}

	internal virtual bool SupportsCleanShutdown
	{
		internal get { } //Length: 3
	}

	public virtual bool SupportsConnectionInfo
	{
		 get { } //Length: 3
	}

	public virtual bool SupportsMonoExtensions
	{
		 get { } //Length: 3
	}

	public virtual bool SupportsSslStream
	{
		 get { } //Length: 3
	}

	public UnityTlsProvider() { }

	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	public virtual Guid get_ID() { }

	public virtual string get_Name() { }

	public virtual SslProtocols get_SupportedProtocols() { }

	internal virtual bool get_SupportsCleanShutdown() { }

	public virtual bool get_SupportsConnectionInfo() { }

	public virtual bool get_SupportsMonoExtensions() { }

	public virtual bool get_SupportsSslStream() { }

	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	[MonoPInvokeCallback(typeof(unitytls_x509verify_callback))]
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

}

