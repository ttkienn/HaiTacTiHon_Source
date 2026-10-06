namespace Mono.Net.Security;

internal abstract class MobileTlsProvider : MonoTlsProvider
{

	protected MobileTlsProvider() { }

	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

}

