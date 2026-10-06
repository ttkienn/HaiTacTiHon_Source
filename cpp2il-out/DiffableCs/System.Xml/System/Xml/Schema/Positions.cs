namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class Positions
{
	private ArrayList positions; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 42
	}

	public Position Item
	{
		 get { } //Length: 154
	}

	public Positions() { }

	public int Add(int symbol, object particle) { }

	public int get_Count() { }

	public Position get_Item(int pos) { }

}

