//Type is in global namespace

public class CreateChar_Screen : MainScreen
{
	public static CreateChar_Screen instance; //Field offset: 0x0
	public const int TOC = 0; //Field offset: 0x0
	public const int NON = 1; //Field offset: 0x0
	public const int AO = 2; //Field offset: 0x0
	public const int QUAN = 3; //Field offset: 0x0
	public static Int16[][] hardcodePart; //Field offset: 0x8
	private TField tfNameChar; //Field offset: 0x50
	private iCommand cmdCreate; //Field offset: 0x58
	private iCommand cmdexit; //Field offset: 0x60
	private int xBegin; //Field offset: 0x68
	private int yBegin; //Field offset: 0x6C
	private int h; //Field offset: 0x70
	private Other_Player otherPl; //Field offset: 0x78
	private mVector vecHeadShow; //Field offset: 0x80
	private int wItem; //Field offset: 0x88

	private static CreateChar_Screen() { }

	public CreateChar_Screen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public static CreateChar_Screen gI() { }

	public virtual bool keyBack() { }

	public virtual void keyPress(int keyCode) { }

	public virtual void paint(mGraphics g) { }

	public static short RanPart(int clazz, int index) { }

	public static Other_Player setCharClass(Other_Player other, bool isRan) { }

	public virtual void setxyPlus12() { }

	public virtual void Show(MainScreen screen) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

