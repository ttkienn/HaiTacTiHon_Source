//Type is in global namespace

public class mFont
{
	public const sbyte LEFT = 0; //Field offset: 0x0
	public static int yAddFont; //Field offset: 0x0
	public const sbyte HP = 9; //Field offset: 0x0
	public const sbyte GREY = 8; //Field offset: 0x0
	public const sbyte FATAL_ME = 8; //Field offset: 0x0
	public const sbyte MISS_ME = 7; //Field offset: 0x0
	public const sbyte ADDMONEY = 6; //Field offset: 0x0
	public const sbyte ORANGE = 5; //Field offset: 0x0
	public const sbyte MP = 10; //Field offset: 0x0
	public const sbyte FATAL = 3; //Field offset: 0x0
	public const sbyte GREEN = 2; //Field offset: 0x0
	public const sbyte YELLOW = 1; //Field offset: 0x0
	public const sbyte RED = 0; //Field offset: 0x0
	public const sbyte CENTER = 2; //Field offset: 0x0
	public const sbyte MISS = 4; //Field offset: 0x0
	public const sbyte RIGHT = 1; //Field offset: 0x0
	public static Int32[] colorPhong; //Field offset: 0x8
	public static Int32[] colorJava; //Field offset: 0x10
	public static mFont gI; //Field offset: 0x18
	public static mFont tahoma_7b_red; //Field offset: 0x20
	public static mFont tahoma_7b_blue; //Field offset: 0x28
	public static mFont tahoma_7b_white; //Field offset: 0x30
	public static mFont tahoma_7b_yellow; //Field offset: 0x38
	public static mFont tahoma_7b_black; //Field offset: 0x40
	public static mFont tahoma_7b_violet; //Field offset: 0x48
	public static mFont tahoma_7b_orange; //Field offset: 0x50
	public static mFont tahoma_7b_green; //Field offset: 0x58
	public static mFont tahoma_7b_brown; //Field offset: 0x60
	public static mFont tahoma_7_red; //Field offset: 0x68
	public static mFont tahoma_7_blue; //Field offset: 0x70
	public static mFont tahoma_7_white; //Field offset: 0x78
	public static mFont tahoma_7_yellow; //Field offset: 0x80
	public static mFont tahoma_7_black; //Field offset: 0x88
	public static mFont tahoma_7_violet; //Field offset: 0x90
	public static mFont tahoma_7_orange; //Field offset: 0x98
	public static mFont tahoma_7_green; //Field offset: 0xA0
	public static mFont tahoma_7_brown; //Field offset: 0xA8
	public static mFont number_yellow; //Field offset: 0xB0
	public static mFont number_red; //Field offset: 0xB8
	public static mFont number_green; //Field offset: 0xC0
	public static mFont number_orange; //Field offset: 0xC8
	public static mFont bigNumber_red; //Field offset: 0xD0
	public static mFont bigNumber_While; //Field offset: 0xD8
	public static mFont bigNumber_yellow; //Field offset: 0xE0
	public static mFont bigNumber_green; //Field offset: 0xE8
	public static mFont bigNumber_orange; //Field offset: 0xF0
	public static mFont bigNumber_blue; //Field offset: 0xF8
	public static mFont fontBigBorder; //Field offset: 0x100
	public static mFont font_f12_White; //Field offset: 0x108
	public static mFont tahoma_7_white_Border; //Field offset: 0x110
	public static mFont tahoma_7b_yellow_Border; //Field offset: 0x118
	public static mFont nameFontRed; //Field offset: 0x120
	public static mFont nameFontYellow; //Field offset: 0x128
	public static mFont nameFontGreen; //Field offset: 0x130
	public static char xu; //Field offset: 0x138
	public static char luong; //Field offset: 0x13A
	public static char huyChuong; //Field offset: 0x13C
	public static string xuStr; //Field offset: 0x140
	public static string luongStr; //Field offset: 0x148
	public static string huyChuongStr; //Field offset: 0x150
	public static Char[] nguyenLieu; //Field offset: 0x158
	public static String[] nguyenLieuStr; //Field offset: 0x160
	private int space; //Field offset: 0x10
	private Image imgFont; //Field offset: 0x18
	private string strFont; //Field offset: 0x20
	private Int32[][] fImages; //Field offset: 0x28
	public Font myFont; //Field offset: 0x30
	private int height; //Field offset: 0x38
	private int wO; //Field offset: 0x3C
	public Color color1; //Field offset: 0x40
	public Color color2; //Field offset: 0x50
	public sbyte id; //Field offset: 0x60
	public sbyte idPhong; //Field offset: 0x61
	public int fstyle; //Field offset: 0x64
	public string st1; //Field offset: 0x68
	public string st2; //Field offset: 0x70
	private int yAdd; //Field offset: 0x78
	private int sizef; //Field offset: 0x7C

	public void _drawString(mGraphics g, string st, int x0, int y0, int align) { }

	private static mFont() { }

	public mFont(sbyte id, sbyte colorP) { }

	public Color bigColor(int id) { }

	public bool compare(string strSource, string str) { }

	public void drawString(mGraphics g, string st, int x, int y, int align) { }

	public void drawString(mGraphics g, string st, int x, int y, int align, bool isBool) { }

	public void drawString(mGraphics g, string st, int x, int y, int align, mFont font) { }

	public void freeImage() { }

	public int getHeight() { }

	public int getWidth(string s) { }

	public int getWidthExactOf(string s) { }

	public int getWidthNotExactOf(string s) { }

	public static void loadmFont() { }

	public void reloadImage() { }

	public Color setColor(int rgb) { }

	public void setColorByID(int ID) { }

	public void setColorByIDPhong(int ID) { }

	public Color setColorFont(sbyte id) { }

	public Color setColorFontPhong(sbyte id) { }

	public void setTypePaint(mGraphics g, string st, int x, int y, int align, sbyte idFont) { }

	public static String[] split(string original, string separator) { }

	public string splitFirst(string str) { }

	public String[] splitFontArray(string src, int lineWidth) { }

	public mVector splitFontVector(string src, int lineWidth) { }

	public static mVector splitFontVector(string src, char c) { }

	public static String[] splitStringSv(string _text, string _searchStr) { }

	public String[] splitStrInLine(string src, int lineWidth) { }

	public ArrayList splitStrInLineA(string src, int lineWidth) { }

}

