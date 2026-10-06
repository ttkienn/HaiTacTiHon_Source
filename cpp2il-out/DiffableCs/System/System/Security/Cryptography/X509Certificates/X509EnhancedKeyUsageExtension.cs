namespace System.Security.Cryptography.X509Certificates;

public sealed class X509EnhancedKeyUsageExtension : X509Extension
{
	private OidCollection _enhKeyUsage; //Field offset: 0x28
	private AsnDecodeStatus _status; //Field offset: 0x30

	public X509EnhancedKeyUsageExtension() { }

	public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(Byte[] extension) { }

	internal Byte[] Encode() { }

	internal virtual string ToString(bool multiLine) { }

}

