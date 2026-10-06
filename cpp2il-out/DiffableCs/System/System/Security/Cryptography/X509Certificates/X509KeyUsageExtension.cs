namespace System.Security.Cryptography.X509Certificates;

public sealed class X509KeyUsageExtension : X509Extension
{
	internal const string oid = "2.5.29.15"; //Field offset: 0x0
	internal const string friendlyName = "Key Usage"; //Field offset: 0x0
	internal const X509KeyUsageFlags all = 33023; //Field offset: 0x0
	private X509KeyUsageFlags _keyUsages; //Field offset: 0x28
	private AsnDecodeStatus _status; //Field offset: 0x2C

	public X509KeyUsageFlags KeyUsages
	{
		 get { } //Length: 106
	}

	public X509KeyUsageExtension() { }

	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical) { }

	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(Byte[] extension) { }

	internal Byte[] Encode() { }

	public X509KeyUsageFlags get_KeyUsages() { }

	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	internal virtual string ToString(bool multiLine) { }

}

