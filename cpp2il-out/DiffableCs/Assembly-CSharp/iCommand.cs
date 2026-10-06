//Type is in global namespace

public class iCommand
{
	public static int wButtonCmd; //Field offset: 0x0
	public static int hButtonCmdNor; //Field offset: 0x4
	public static int hButtonCmdSpec; //Field offset: 0x8
	public static sbyte BTT_NOR; //Field offset: 0xC
	public static sbyte BTT_SPEC; //Field offset: 0xD
	public static sbyte BTT_NONE; //Field offset: 0xE
	public static sbyte BTT_RED; //Field offset: 0xF
	public static sbyte BTT_GREEN; //Field offset: 0x10
	public string caption; //Field offset: 0x10
	public string clickCaption; //Field offset: 0x18
	public String[] subCaption; //Field offset: 0x20
	public IAction action; //Field offset: 0x28
	public AvMain Pointer; //Field offset: 0x30
	public int indexMenu; //Field offset: 0x38
	public int subIndex; //Field offset: 0x3C
	public bool isSelect; //Field offset: 0x40
	public int levelSmall; //Field offset: 0x44
	public int nframe; //Field offset: 0x48
	public int beginframe; //Field offset: 0x4C
	public int timeSelect; //Field offset: 0x50
	public FrameImage fraImgCaption; //Field offset: 0x58
	public FrameImage fraImageCmd; //Field offset: 0x60
	public int wimgCaption; //Field offset: 0x68
	public int himgCaption; //Field offset: 0x6C
	public int wstr; //Field offset: 0x70
	public int wimgCmd; //Field offset: 0x74
	public int himgCmd; //Field offset: 0x78
	public int xCmd; //Field offset: 0x7C
	public int yCmd; //Field offset: 0x80
	public int frameCmd; //Field offset: 0x84
	public int xdich; //Field offset: 0x88
	public int ydich; //Field offset: 0x8C
	private sbyte typeButton; //Field offset: 0x90
	public bool isEffText; //Field offset: 0x91
	public bool hardcodeEvent; //Field offset: 0x92
	public bool isDonotCloseMenu; //Field offset: 0x93
	public bool isPlayframe; //Field offset: 0x94
	public int IdGiaotiep; //Field offset: 0x98
	private mFont fontCmd; //Field offset: 0xA0
	public MainItem item; //Field offset: 0xA8
	public short idIconClan; //Field offset: 0xB0
	public short lvClan; //Field offset: 0xB2
	public short IdImage; //Field offset: 0xB4
	private CountDownTicket timeCount; //Field offset: 0xB8
	public bool isDisplay; //Field offset: 0xC0
	public bool isSaved; //Field offset: 0xC1
	private int xnone; //Field offset: 0xC4
	private int ynone; //Field offset: 0xC8
	private int wnone; //Field offset: 0xCC
	private int hnone; //Field offset: 0xD0
	private int lechHfra; //Field offset: 0xD4

	private static iCommand() { }

	public iCommand(string caption, int type, int subIndex) { }

	public iCommand(string caption, int type, int subType, AvMain pointer) { }

	public iCommand(string caption, IAction action) { }

	public iCommand(string caption, int type) { }

	public iCommand(string caption, int type, AvMain pointer) { }

	public bool isPosCmd() { }

	public void paint(mGraphics g, int x, int y) { }

	public void paintbutton(mGraphics g, int x, int y) { }

	public void paintbuttonCmd1Frame(mGraphics g, int x, int y) { }

	public void paintCaptionImage(mGraphics g, int x, int y, int pos) { }

	public void paintCaptionImageMenu(mGraphics g, int x, int y, int pos, bool is3D) { }

	public void paintClickCaption(mGraphics g, int x, int y, int pos) { }

	public void paintCmd1Frame(mGraphics g, int x, int y) { }

	public void paintImageCaption(mGraphics g) { }

	public void paintOnlyCaption(mGraphics g, int x, int y) { }

	public void paintOnlyImage(mGraphics g, int x, int y, sbyte focus) { }

	public void paintXY(mGraphics g, int x, int y) { }

	public void perform() { }

	public void setFont(mFont f) { }

	public void setFraCaption(FrameImage fra) { }

	public void setFraCaption(FrameImage fra, int nframe, int beginframe, int lech) { }

	public void setFraCaption(mImage img) { }

	public void setIdIconClan(short IdIconClan) { }

	public void setIsEffTest(bool isEff) { }

	public void setItem(MainItem item) { }

	public void setPos(int x, int y, mImage img, string caption, int nframe) { }

	public void setPos(int x, int y, FrameImage fra, string caption) { }

	public void setPos_ShowName(int x, int y, FrameImage fra, string clickcaption, int xdich, int ydich) { }

	public void setPosXY(int x, int y) { }

	public void setTime(int time) { }

	public void setTypeButton(sbyte type) { }

	public void setTypeGreen() { }

	public void setTypeNone(int x, int y, int w, int h) { }

	public void setTypeRed() { }

	public void setTypeSpec() { }

	public void update() { }

	public void updatePointer() { }

	public void updatePointer(int cmx, int cmy) { }

	public void updatePointerCameraScreen(Camera cam) { }

	public void updatePointerInList(int yList) { }

	public void updatePointerNapThe(int xBtn, int yBtn) { }

	public void updatePointerShow(int cmx, int cmy) { }

}

