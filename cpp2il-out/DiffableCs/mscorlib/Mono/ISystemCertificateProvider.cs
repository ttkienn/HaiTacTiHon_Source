namespace Mono;

internal interface ISystemCertificateProvider
{

	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	public X509CertificateImpl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	public X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

}

