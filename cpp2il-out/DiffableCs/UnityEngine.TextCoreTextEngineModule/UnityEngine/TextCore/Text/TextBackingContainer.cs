namespace UnityEngine.TextCore.Text;

[DefaultMember("Item")]
internal struct TextBackingContainer
{
	private UInt32[] m_Array; //Field offset: 0x0
	private int m_Count; //Field offset: 0x8

	public int Capacity
	{
		 get { } //Length: 25
	}

	public int Count
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public uint Item
	{
		 get { } //Length: 42
		 set { } //Length: 136
	}

	public TextBackingContainer(int size) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public uint get_Item(int index) { }

	public void Resize(int size) { }

	public void set_Count(int value) { }

	public void set_Item(int index, uint value) { }

}

