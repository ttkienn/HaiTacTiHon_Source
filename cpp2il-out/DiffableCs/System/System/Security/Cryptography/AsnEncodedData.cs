namespace System.Security.Cryptography;

public class AsnEncodedData
{
	internal Oid _oid; //Field offset: 0x10
	internal Byte[] _raw; //Field offset: 0x18

	public Oid Oid
	{
		 get { } //Length: 5
		 set { } //Length: 165
	}

	public Byte[] RawData
	{
		 get { } //Length: 5
		 set { } //Length: 252
	}

	protected AsnEncodedData() { }

	public AsnEncodedData(string oid, Byte[] rawData) { }

	public AsnEncodedData(Oid oid, Byte[] rawData) { }

	public AsnEncodedData(AsnEncodedData asnEncodedData) { }

	internal string BasicConstraintsExtension(bool multiLine) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string Default(bool multiLine) { }

	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	public override string Format(bool multiLine) { }

	public Oid get_Oid() { }

	public Byte[] get_RawData() { }

	internal string KeyUsageExtension(bool multiLine) { }

	internal string NetscapeCertType(bool multiLine) { }

	public void set_Oid(Oid value) { }

	public void set_RawData(Byte[] value) { }

	internal string SubjectAltName(bool multiLine) { }

	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	internal override string ToString(bool multiLine) { }

}

