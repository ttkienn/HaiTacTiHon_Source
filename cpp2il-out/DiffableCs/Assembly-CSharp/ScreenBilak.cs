//Type is in global namespace

public class ScreenBilak : MainScreen
{
	public static String[] strListPlayer; //Field offset: 0x0
	public static Int32[] valueTeam; //Field offset: 0x8
	public static Int32[] valueWin; //Field offset: 0x10
	public static int ValueAction; //Field offset: 0x18
	public static int demNG; //Field offset: 0x1C
	public static int demTop; //Field offset: 0x20
	private mVector vecCmd; //Field offset: 0x50
	private iCommand cmdSetTop; //Field offset: 0x58
	private iCommand cmdOff; //Field offset: 0x60
	private iCommand cmdMyRandom; //Field offset: 0x68
	private iCommand cmdTableAfter; //Field offset: 0x70
	private iCommand cmdSetCongWin; //Field offset: 0x78
	private iCommand cmdSetTruWin; //Field offset: 0x80
	private iCommand cmdTop6; //Field offset: 0x88
	private iCommand cmdOffTable; //Field offset: 0x90
	private Int32[][] valuePlay; //Field offset: 0x98
	private string strSoNguoi; //Field offset: 0xA0
	private string strTop; //Field offset: 0xA8
	private string strLe; //Field offset: 0xB0
	private string strRMS; //Field offset: 0xB8
	private String[] strSauCheck; //Field offset: 0xC0
	private String[] stListPlayerFight; //Field offset: 0xC8

	private static ScreenBilak() { }

	public ScreenBilak() { }

	private void autoSetTop6() { }

	public void commandPointer(int index, int subIndex) { }

	private void getStrSauCheck() { }

	public void paint(mGraphics g) { }

	public void updatePointer() { }

}

