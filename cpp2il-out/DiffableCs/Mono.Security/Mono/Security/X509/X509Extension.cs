namespace Mono.Security.X509;

public class X509Extension
{
	protected string extnOid; //Field offset: 0x10
	protected bool extnCritical; //Field offset: 0x18
	protected ASN1 extnValue; //Field offset: 0x20

	public bool Critical
	{
		 get { } //Length: 5
	}

	public string Oid
	{
		 get { } //Length: 5
	}

	public ASN1 Value
	{
		 get { } //Length: 55
	}

	public X509Extension(ASN1 asn1) { }

	public X509Extension(X509Extension extension) { }

	protected override void Decode() { }

	protected override void Encode() { }

	public virtual bool Equals(object obj) { }

	public bool get_Critical() { }

	public string get_Oid() { }

	public ASN1 get_Value() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

	private void WriteLine(StringBuilder sb, int n, int pos) { }

}

