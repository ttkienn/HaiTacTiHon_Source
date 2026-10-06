namespace Mono;

internal class X509PalImplMono : X509PalImpl
{

	public X509PalImplMono() { }

	public virtual X509CertificateImpl Import(Byte[] data) { }

	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

