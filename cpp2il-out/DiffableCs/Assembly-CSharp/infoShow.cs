//Type is in global namespace

public class infoShow
{
	public static sbyte HARDCODE_CHECK_LVRQ; //Field offset: 0x0
	public static sbyte HARDCODE_PAINT_CENTER; //Field offset: 0x1
	public static sbyte HARDCODE_PAINT_CENTER_CHI_SO; //Field offset: 0x2
	public static sbyte HARDCODE_INFO_CO_BAN; //Field offset: 0x3
	public static sbyte HARDCODE_CHECK_FULLSET_1; //Field offset: 0x4
	public static sbyte HARDCODE_CHECK_FULLSET_2; //Field offset: 0x5
	public static sbyte HARDCODE_CHECK_FULLSET_3; //Field offset: 0x6
	public static sbyte HARDCODE_CHECK_FULLSET_4; //Field offset: 0x7
	public static sbyte HARDCODE_CHECK_FULLSET_5; //Field offset: 0x8
	public string strShow; //Field offset: 0x10
	public sbyte color; //Field offset: 0x18
	public sbyte colorMain; //Field offset: 0x19
	public int id; //Field offset: 0x1C
	public int value; //Field offset: 0x20

	private static infoShow() { }

	public infoShow(int id, int value, string str, sbyte color, sbyte colorMain) { }

	public infoShow(int id, int value, sbyte color, sbyte colorMain) { }

	public string getInfoFormID() { }

}

