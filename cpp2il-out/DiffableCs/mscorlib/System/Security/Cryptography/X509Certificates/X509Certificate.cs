namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	private X509CertificateImpl impl; //Field offset: 0x10
	private Byte[] lazyCertHash; //Field offset: 0x18
	private Byte[] lazySerialNumber; //Field offset: 0x20
	private string lazyIssuer; //Field offset: 0x28
	private string lazySubject; //Field offset: 0x30
	private string lazyKeyAlgorithm; //Field offset: 0x38
	private Byte[] lazyKeyAlgorithmParameters; //Field offset: 0x40
	private Byte[] lazyPublicKey; //Field offset: 0x48
	private DateTime lazyNotBefore; //Field offset: 0x50
	private DateTime lazyNotAfter; //Field offset: 0x58

	internal X509CertificateImpl Impl
	{
		internal get { } //Length: 5
	}

	public string Issuer
	{
		 get { } //Length: 165
	}

	internal bool IsValid
	{
		internal get { } //Length: 32
	}

	public string Subject
	{
		 get { } //Length: 165
	}

	public X509Certificate() { }

	public X509Certificate(Byte[] data) { }

	public X509Certificate(Byte[] rawData, string password) { }

	public X509Certificate(Byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	internal X509Certificate(X509CertificateImpl impl) { }

	public X509Certificate(X509Certificate cert) { }

	public X509Certificate(SerializationInfo info, StreamingContext context) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override bool Equals(X509Certificate other) { }

	public virtual bool Equals(object obj) { }

	public override Byte[] Export(X509ContentType contentType, string password) { }

	protected static string FormatDate(DateTime date) { }

	internal X509CertificateImpl get_Impl() { }

	public string get_Issuer() { }

	internal bool get_IsValid() { }

	public string get_Subject() { }

	public override Byte[] GetCertHash() { }

	public override string GetCertHashString() { }

	public virtual int GetHashCode() { }

	public override string GetKeyAlgorithm() { }

	public override Byte[] GetKeyAlgorithmParameters() { }

	internal DateTime GetNotAfter() { }

	internal DateTime GetNotBefore() { }

	public override Byte[] GetPublicKey() { }

	public override Byte[] GetRawCertData() { }

	private Byte[] GetRawCertHash() { }

	private Byte[] GetRawSerialNumber() { }

	public override Byte[] GetSerialNumber() { }

	public override string GetSerialNumberString() { }

	internal void ImportHandle(X509CertificateImpl impl) { }

	public override void Reset() { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void ThrowIfInvalid() { }

	public virtual string ToString() { }

	public override string ToString(bool fVerbose) { }

	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	private void VerifyContentType(X509ContentType contentType) { }

}

