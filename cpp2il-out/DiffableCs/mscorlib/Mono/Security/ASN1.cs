namespace Mono.Security;

[DefaultMember("Item")]
internal class ASN1
{
	private byte m_nTag; //Field offset: 0x10
	private Byte[] m_aValue; //Field offset: 0x18
	private ArrayList elist; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 34
	}

	public Byte[] Value
	{
		 get { } //Length: 148
	}

	public ASN1(byte tag) { }

	public ASN1(byte tag, Byte[] data) { }

	public ASN1(Byte[] data) { }

	public ASN1 Add(ASN1 asn1) { }

	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	public int get_Count() { }

	public Byte[] get_Value() { }

	public override Byte[] GetBytes() { }

	public virtual string ToString() { }

}

