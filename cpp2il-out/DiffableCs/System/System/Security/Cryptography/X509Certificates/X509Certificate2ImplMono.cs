namespace System.Security.Cryptography.X509Certificates;

internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
{
	private static string empty_error; //Field offset: 0x0
	private static Byte[] signedData; //Field offset: 0x8
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xB0
	private X509Certificate _cert; //Field offset: 0xB8

	private X509Certificate Cert
	{
		private get { } //Length: 29
	}

	public virtual bool HasPrivateKey
	{
		 get { } //Length: 34
	}

	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		internal get { } //Length: 8
	}

	public virtual bool IsValid
	{
		 get { } //Length: 12
	}

	internal X509Certificate MonoCertificate
	{
		internal get { } //Length: 8
	}

	public virtual AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 1100
		 set { } //Length: 608
	}

	private static X509Certificate2ImplMono() { }

	public X509Certificate2ImplMono(X509Certificate cert) { }

	private X509Certificate2ImplMono(X509Certificate2ImplMono other) { }

	public X509Certificate2ImplMono(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public virtual X509CertificateImpl Clone() { }

	private X509Certificate get_Cert() { }

	public virtual bool get_HasPrivateKey() { }

	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	public virtual bool get_IsValid() { }

	internal X509Certificate get_MonoCertificate() { }

	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	public virtual DSA GetDSAPrivateKey() { }

	protected virtual Byte[] GetRawCertData() { }

	public virtual RSA GetRSAPrivateKey() { }

	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

