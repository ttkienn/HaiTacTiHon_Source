namespace System.Security.Cryptography.X509Certificates;

public class X509Extension : AsnEncodedData
{
	private bool _critical; //Field offset: 0x20

	public bool Critical
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	protected X509Extension() { }

	public X509Extension(string oid, Byte[] rawData, bool critical) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string FormatUnkownData(Byte[] data) { }

	public bool get_Critical() { }

	public void set_Critical(bool value) { }

}

