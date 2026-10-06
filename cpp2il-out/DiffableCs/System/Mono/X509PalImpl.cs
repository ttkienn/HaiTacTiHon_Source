namespace Mono;

internal abstract class X509PalImpl
{
	private static Byte[] signedData; //Field offset: 0x0

	public bool SupportsLegacyBasicConstraintsExtension
	{
		 get { } //Length: 3
	}

	private static X509PalImpl() { }

	protected X509PalImpl() { }

	protected static Byte[] ConvertData(Byte[] data) { }

	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	public X509ContentType GetCertContentType(Byte[] rawData) { }

	public abstract X509CertificateImpl Import(Byte[] data) { }

	public abstract X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public abstract X509Certificate2Impl Import(X509Certificate cert) { }

	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	private static Byte[] PEM(string type, Byte[] data) { }

}

