namespace Mono;

internal class SystemCertificateProvider : ISystemCertificateProvider
{
	private static MonoTlsProvider provider; //Field offset: 0x0
	private static int initialized; //Field offset: 0x8
	private static X509PalImpl x509pal; //Field offset: 0x10
	private static object syncRoot; //Field offset: 0x18

	public X509PalImpl X509Pal
	{
		 get { } //Length: 83
	}

	private static SystemCertificateProvider() { }

	public SystemCertificateProvider() { }

	private static void EnsureInitialized() { }

	public X509PalImpl get_X509Pal() { }

	private static X509PalImpl GetX509Pal() { }

	public override X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

}

