//Type is in global namespace

public class MainInfoItem
{
	public sbyte id; //Field offset: 0x10
	public sbyte color; //Field offset: 0x11
	public sbyte ispercent; //Field offset: 0x12
	public sbyte colorMain; //Field offset: 0x13
	public int value; //Field offset: 0x14
	public string name; //Field offset: 0x18

	public MainInfoItem(sbyte id, int value) { }

	public MainInfoItem(sbyte id, int value, sbyte colorM) { }

	public MainInfoItem(string name, sbyte color, sbyte percent) { }

	public MainInfoItem(string name, int value) { }

}

