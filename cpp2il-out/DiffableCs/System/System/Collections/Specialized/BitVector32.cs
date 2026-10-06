namespace System.Collections.Specialized;

[DefaultMember("Item")]
public struct BitVector32
{
	private uint _data; //Field offset: 0x0

	public bool Item
	{
		 get { } //Length: 18
		 set { } //Length: 19
	}

	public static int CreateMask() { }

	public static int CreateMask(int previous) { }

	public virtual bool Equals(object o) { }

	public bool get_Item(int bit) { }

	public virtual int GetHashCode() { }

	public void set_Item(int bit, bool value) { }

	public static string ToString(BitVector32 value) { }

	public virtual string ToString() { }

}

