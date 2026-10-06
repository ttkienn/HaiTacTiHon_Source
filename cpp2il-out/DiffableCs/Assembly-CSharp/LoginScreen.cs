//Type is in global namespace

public class LoginScreen : MainScreen
{
	public static bool isCheckData; //Field offset: 0x0
	public const sbyte LOGIN = 0; //Field offset: 0x0
	public const sbyte REGISTER = 1; //Field offset: 0x0
	public static iCommand cmdSound; //Field offset: 0x8
	public static int yBeginPaint; //Field offset: 0x10
	public static mVector vecEff; //Field offset: 0x18
	public static mVector vecOBJ; //Field offset: 0x20
	private static bool isNewShow; //Field offset: 0x28
	private static bool isLoadDataCharShowOk; //Field offset: 0x29
	public static int yPaintLogo; //Field offset: 0x2C
	public static int dy; //Field offset: 0x30
	public static int hLogo; //Field offset: 0x34
	public static int frameBanhlai; //Field offset: 0x38
	public static int tickBanhLai; //Field offset: 0x3C
	public static short idRan; //Field offset: 0x40
	public sbyte type; //Field offset: 0x50
	public TField tfUser; //Field offset: 0x58
	public TField tfPass; //Field offset: 0x60
	public TField tfIp; //Field offset: 0x68
	private iCommand cmdLogin; //Field offset: 0x70
	private iCommand cmdMenu; //Field offset: 0x78
	private iCommand cmdRegister; //Field offset: 0x80
	private iCommand cmdExitGame; //Field offset: 0x88
	private iCommand cmdLowGraphic; //Field offset: 0x90
	private iCommand cmdFristLogin; //Field offset: 0x98
	private iCommand cmdHelp; //Field offset: 0xA0
	private iCommand cmdLastLogin; //Field offset: 0xA8
	private iCommand cmdDelRMS; //Field offset: 0xB0
	private iCommand cmdOffBg; //Field offset: 0xB8
	private iCommand cmdTaitho; //Field offset: 0xC0
	private iCommand cmdOnLowGraphicPc; //Field offset: 0xC8
	private mVector vecCmd; //Field offset: 0xD0
	private int hItem; //Field offset: 0xD8
	private int idSelect; //Field offset: 0xDC
	private int sizeListServer; //Field offset: 0xE0
	private int yLechNameServer; //Field offset: 0xE4
	private InputDialog input; //Field offset: 0xE8
	private string nameDevice; //Field offset: 0xF0
	private int wShowPaper; //Field offset: 0xF8
	private int maxWShow; //Field offset: 0xFC
	private int vShow; //Field offset: 0x100
	private int hShowPaper; //Field offset: 0x104

	private static LoginScreen() { }

	public LoginScreen() { }

	public static void addEffectEnd(short type, int subtype, int x, int y, sbyte dir, MainObject objEff) { }

	public static void addObjShow(bool isNew) { }

	public static void beginShowChar() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void doLogin(bool isGetData, sbyte typeLogin, string user, string pass) { }

	public virtual bool keyBack() { }

	public virtual void keyPress(int keyCode) { }

	public static void loadCharPart() { }

	public virtual void paint(mGraphics g) { }

	public void paintListServer(mGraphics g) { }

	public static void paintLogo(mGraphics g, int x) { }

	public static void paintShowchar(mGraphics g) { }

	public void readSpeedUpRMS() { }

	private void saveIP_New() { }

	private void saveLvGraphicPC() { }

	public void setCmd() { }

	public void setCmdClear() { }

	public void setData() { }

	public void setIndexServer(int index) { }

	public virtual void setxyPlus12() { }

	public virtual void Show(MainScreen last) { }

	public virtual void Show() { }

	public virtual void update() { }

	public static void updateBanhLai() { }

	public static void updateCharShow() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public static void updateYPaintLogo(int y) { }

}

