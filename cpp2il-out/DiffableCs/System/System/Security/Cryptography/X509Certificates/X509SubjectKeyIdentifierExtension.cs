namespace System.Security.Cryptography.X509Certificates;

public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	internal const string oid = "2.5.29.14"; //Field offset: 0x0
	internal const string friendlyName = "Subject Key Identifier"; //Field offset: 0x0
	private Byte[] _subjectKeyIdentifier; //Field offset: 0x28
	private string _ski; //Field offset: 0x30
	private AsnDecodeStatus _status; //Field offset: 0x38

	public string SubjectKeyIdentifier
	{
		 get { } //Length: 222
	}

	public X509SubjectKeyIdentifierExtension() { }

	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	public X509SubjectKeyIdentifierExtension(Byte[] subjectKeyIdentifier, bool critical) { }

	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) { }

	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical) { }

	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(Byte[] extension) { }

	internal Byte[] Encode() { }

	internal static Byte[] FromHex(string hex) { }

	internal static byte FromHexChar(char c) { }

	internal static byte FromHexChars(char c1, char c2) { }

	public string get_SubjectKeyIdentifier() { }

	internal virtual string ToString(bool multiLine) { }

}

