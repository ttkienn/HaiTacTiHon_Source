namespace Mono.Btls;

internal class X509PalImplBtls : X509PalImpl
{
	[CompilerGenerated]
	private readonly MonoBtlsProvider <Provider>k__BackingField; //Field offset: 0x10

	private MonoBtlsProvider Provider
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public X509PalImplBtls(MonoTlsProvider provider) { }

	[CompilerGenerated]
	private MonoBtlsProvider get_Provider() { }

	public virtual X509CertificateImpl Import(Byte[] data) { }

	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

