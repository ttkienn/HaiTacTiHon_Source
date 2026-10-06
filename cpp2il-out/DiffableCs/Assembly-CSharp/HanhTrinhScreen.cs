//Type is in global namespace

public class HanhTrinhScreen : MainScreen
{
	public static HanhTrinhScreen instance; //Field offset: 0x0
	private static Int32[][] mpos; //Field offset: 0x8
	public string nameList; //Field offset: 0x50
	protected int x; //Field offset: 0x58
	protected int y; //Field offset: 0x5C
	protected int w; //Field offset: 0x60
	protected int h; //Field offset: 0x64
	private FrameImage fraNen; //Field offset: 0x68
	private iCommand cmdClose; //Field offset: 0x70
	public mVector vecCmd; //Field offset: 0x78
	public String[] mTenLang; //Field offset: 0x80
	public Int16[] mIcon; //Field offset: 0x88

	private static HanhTrinhScreen() { }

	public HanhTrinhScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public virtual void updatePointer() { }

}

