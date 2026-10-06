namespace System.Xml.Schema;

[DefaultMember("Item")]
internal sealed class BitSet
{
	private int count; //Field offset: 0x10
	private UInt32[] bits; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 191
	}

	public bool IsEmpty
	{
		 get { } //Length: 79
	}

	public bool Item
	{
		 get { } //Length: 79
	}

	private BitSet() { }

	public BitSet(int count) { }

	public void And(BitSet other) { }

	public void Clear() { }

	public BitSet Clone() { }

	private void EnsureLength(int nRequiredLength) { }

	public virtual bool Equals(object obj) { }

	public bool Get(int index) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public bool get_Item(int index) { }

	public virtual int GetHashCode() { }

	public bool Intersects(BitSet other) { }

	public int NextSet(int startFrom) { }

	public void Or(BitSet other) { }

	public void Set(int index) { }

	private int Subscript(int bitIndex) { }

}

