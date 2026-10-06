namespace Mono.Unity;

internal static class UnityTlsConversions
{

	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

}

