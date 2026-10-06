//Type is in global namespace

public class TField
{
	public const sbyte KEY_RIGHT = 15; //Field offset: 0x0
	public static int typeXpeed; //Field offset: 0x0
	public const sbyte KEY_CLEAR = 19; //Field offset: 0x0
	public const sbyte KEY_LEFT = 14; //Field offset: 0x0
	private static readonly Int32[] MAX_TIME_TO_CONFIRM_KEY; //Field offset: 0x8
	private static int CARET_HEIGHT; //Field offset: 0x10
	private static readonly int CARET_WIDTH; //Field offset: 0x14
	private static readonly int CARET_SHOWING_TIME; //Field offset: 0x18
	private static readonly int TEXT_GAP_X; //Field offset: 0x1C
	private static readonly int MAX_SHOW_CARET_COUNER; //Field offset: 0x20
	public static readonly int INPUT_TYPE_ANY; //Field offset: 0x24
	public static readonly int INPUT_TYPE_NUMERIC; //Field offset: 0x28
	public static readonly int INPUT_TYPE_PASSWORD; //Field offset: 0x2C
	public static readonly int INPUT_ALPHA_NUMBER_ONLY; //Field offset: 0x30
	private static String[] print; //Field offset: 0x38
	private static String[] printA; //Field offset: 0x40
	private static String[] printBB; //Field offset: 0x48
	private static int lastKey; //Field offset: 0x50
	public static bool isQwerty; //Field offset: 0x54
	public static int typingModeAreaWidth; //Field offset: 0x58
	public static int mode; //Field offset: 0x5C
	public static long timeChangeMode; //Field offset: 0x60
	public static readonly String[] modeNotify; //Field offset: 0x68
	public static readonly int NOKIA; //Field offset: 0x70
	public static readonly int MOTO; //Field offset: 0x74
	public static readonly int ORTHER; //Field offset: 0x78
	public static readonly int BB; //Field offset: 0x7C
	public static int changeModeKey; //Field offset: 0x80
	public static readonly sbyte abc; //Field offset: 0x84
	public static readonly sbyte Abc; //Field offset: 0x85
	public static readonly sbyte ABC; //Field offset: 0x86
	public static readonly sbyte number123; //Field offset: 0x87
	public static TField currentTField; //Field offset: 0x88
	public static int changeDau; //Field offset: 0x90
	private static string printDau; //Field offset: 0x98
	public static Image imgTf; //Field offset: 0xA0
	public static TouchScreenKeyboard kb; //Field offset: 0xA8
	public static Int32[][] BBKEY; //Field offset: 0xB0
	public static int xDu; //Field offset: 0xB8
	public bool isFocus; //Field offset: 0x10
	public int x; //Field offset: 0x14
	public int y; //Field offset: 0x18
	public int width; //Field offset: 0x1C
	public int height; //Field offset: 0x20
	public bool lockArrow; //Field offset: 0x24
	public bool justReturnFromTextBox; //Field offset: 0x25
	public bool paintFocus; //Field offset: 0x26
	private string text; //Field offset: 0x28
	private string passwordText; //Field offset: 0x30
	private string paintedText; //Field offset: 0x38
	private int caretPos; //Field offset: 0x40
	private int counter; //Field offset: 0x44
	private int maxTextLenght; //Field offset: 0x48
	private int offsetX; //Field offset: 0x4C
	private int keyInActiveState; //Field offset: 0x50
	private int indexOfActiveChar; //Field offset: 0x54
	private int showCaretCounter; //Field offset: 0x58
	private int inputType; //Field offset: 0x5C
	public bool isCloseKey; //Field offset: 0x60
	public bool isOpenTextBox; //Field offset: 0x61
	public bool isTfield; //Field offset: 0x62
	public bool isPaintMouse; //Field offset: 0x63
	public string name; //Field offset: 0x68
	public string title; //Field offset: 0x70
	public string strnull; //Field offset: 0x78
	public string strInfo; //Field offset: 0x80
	public bool isOpenKey; //Field offset: 0x88
	public iCommand cmdClear; //Field offset: 0x90
	public iCommand cmdDoneAction; //Field offset: 0x98
	private MainScreen parentScr; //Field offset: 0xA0
	private int timeDelayKyCode; //Field offset: 0xA8
	private int xSpace; //Field offset: 0xAC
	private int holdCount; //Field offset: 0xB0
	private int indexDau; //Field offset: 0xB4
	private int indexTemplate; //Field offset: 0xB8
	private int indexCong; //Field offset: 0xBC
	private long timeDau; //Field offset: 0xC0
	public int timeFocus; //Field offset: 0xC8
	public int xCamText; //Field offset: 0xCC
	public int timePutKeyClearAll; //Field offset: 0xD0
	public int timeClearFirt; //Field offset: 0xD4
	public bool isPaintCarret; //Field offset: 0xD8
	public bool showSubTextField; //Field offset: 0xD9
	public bool isChangeFocus; //Field offset: 0xDA

	private static TField() { }

	public TField(string text, int maxLen, int inputType) { }

	public TField(int x, int y, int width) { }

	public TField(int x, int y, int w, int h) { }

	public TField() { }

	public TField(MainScreen parentScr) { }

	public void clear() { }

	public void clearAll() { }

	public void clearAllText() { }

	public void clearKb() { }

	public void clearKeyWhenPutText(int keyCode) { }

	public bool closeInput() { }

	public void doChangeToTextBox() { }

	public static int getHeight() { }

	public int getIputType() { }

	public int getMaxTextLenght() { }

	public string getText() { }

	public void init() { }

	public void insertText(string text) { }

	public bool isFocused() { }

	public bool keyPressed(int keyCode) { }

	public void keyPressedAny(int keyCode) { }

	public void keyPressedAscii(int keyCode) { }

	public void paint(mGraphics g, bool isSetClip) { }

	public void paint(mGraphics g) { }

	public void paintInputTf(mGraphics g, bool iss, int x, int y, int w, int h, int xText, int yText, string text, string info) { }

	public void paintNew(mGraphics g) { }

	public void perform(int idAction) { }

	public iCommand setCmdClear() { }

	private void setDau() { }

	public void setFocus(bool isFocus) { }

	public void setFocusWithKb(bool isFocus) { }

	public void setheightText() { }

	public void setIputType(int iputType) { }

	public void setMaxTextLenght(int maxTextLenght) { }

	public static void setMode() { }

	public static bool setNormal(char ch) { }

	public void setOffset(int index) { }

	public void setOffset() { }

	private void setPasswordTest() { }

	public void setPoiter() { }

	public void setStringNull(string str) { }

	public void setText(string text) { }

	public void setTextBox(int camY) { }

	public static void setVendorTypeMode(int mode) { }

	public void setW(int w) { }

	public string subString(string str, int index, int indexTo) { }

	public void update() { }

	public void updatePointer(int camY) { }

	public void updatePointer() { }

}

