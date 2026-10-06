//Type is in global namespace

public class Main_Attribute
{
	public sbyte type; //Field offset: 0x10
	public short value; //Field offset: 0x12
	public short valuePlus; //Field offset: 0x14
	public string name; //Field offset: 0x18
	public MainInfoItem[] minfo; //Field offset: 0x20

	public Main_Attribute(sbyte type, short value, short valueP, string name, MainInfoItem[] minfo) { }

}

