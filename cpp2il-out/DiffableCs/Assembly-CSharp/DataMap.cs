//Type is in global namespace

public class DataMap
{
	public static MyHashTable hashDataMap; //Field offset: 0x0
	public SByte[] dataItemMap; //Field offset: 0x10
	public SByte[] dataMap; //Field offset: 0x18
	public mVector vecPointMap; //Field offset: 0x20
	public short hBack; //Field offset: 0x28
	public sbyte IdBack; //Field offset: 0x2A
	public string nameMap; //Field offset: 0x30

	private static DataMap() { }

	public DataMap() { }

	public void setAddVecPointMap(Message msg) { }

	public void setDataItemMap(SByte[] mdata) { }

	public void setDataMap(SByte[] mdata) { }

}

