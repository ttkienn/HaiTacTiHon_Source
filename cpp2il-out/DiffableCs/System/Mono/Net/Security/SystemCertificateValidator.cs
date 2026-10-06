namespace Mono.Net.Security;

internal static class SystemCertificateValidator
{
	private static bool is_macosx; //Field offset: 0x0
	private static X509KeyUsageFlags s_flags; //Field offset: 0x4

	private static SystemCertificateValidator() { }

	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

