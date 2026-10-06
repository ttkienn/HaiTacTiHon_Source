namespace Mono.Btls;

internal class MonoBtlsProvider : MobileTlsProvider
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

	internal MonoBtlsProvider() { }

	private static void AddMachineStore(MonoBtlsX509Store store) { }

	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	private static void AddUserStore(MonoBtlsX509Store store) { }

	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) { }

	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	public virtual Guid get_ID() { }

	public virtual string get_Name() { }

	public virtual SslProtocols get_SupportedProtocols() { }

	internal virtual bool get_SupportsCleanShutdown() { }

	public virtual bool get_SupportsConnectionInfo() { }

	public virtual bool get_SupportsMonoExtensions() { }

	public virtual bool get_SupportsSslStream() { }

	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

}

