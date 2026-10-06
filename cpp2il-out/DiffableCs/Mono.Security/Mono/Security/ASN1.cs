namespace Mono.Security;

[DefaultMember("Item")]
public class ASN1
{
	private byte m_nTag; //Field offset: 0x10
	private Byte[] m_aValue; //Field offset: 0x18
	private ArrayList elist; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 34
	}

	public ASN1 Item
	{
		 get { } //Length: 195
	}

	public int Length
	{
		 get { } //Length: 18
	}

	public byte Tag
	{
		 get { } //Length: 5
	}

	public Byte[] Value
	{
		 get { } //Length: 148
		 set { } //Length: 176
	}

	public ASN1(byte tag) { }

	public ASN1(byte tag, Byte[] data) { }

	public ASN1(Byte[] data) { }

	public ASN1 Add(ASN1 asn1) { }

	private bool CompareArray(Byte[] array1, Byte[] array2) { }

	public bool CompareValue(Byte[] value) { }

	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	public ASN1 Element(int index, byte anTag) { }

	public int get_Count() { }

	public ASN1 get_Item(int index) { }

	public int get_Length() { }

	public byte get_Tag() { }

	public Byte[] get_Value() { }

	public override Byte[] GetBytes() { }

	public void set_Value(Byte[] value) { }

	public virtual string ToString() { }

}

