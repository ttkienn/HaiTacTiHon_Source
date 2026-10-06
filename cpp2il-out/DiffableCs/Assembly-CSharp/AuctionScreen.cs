//Type is in global namespace

public class AuctionScreen : PaintListScreen
{
	public const sbyte TYPE_LIST = 0; //Field offset: 0x0
	public const sbyte TYPE_DAU_GIA = 1; //Field offset: 0x0
	public const sbyte TYPE_NHAN = 2; //Field offset: 0x0
	public const sbyte TYPE_GIA_CHOT = 3; //Field offset: 0x0
	public const sbyte TYPE_CLOSE = 4; //Field offset: 0x0
	public static AuctionScreen instance; //Field offset: 0x0
	public static mVector vecEff; //Field offset: 0x8
	private mVector vecCmdDauGia; //Field offset: 0x100
	private mVector vecCmdGiaChot; //Field offset: 0x108
	private mVector vecCmdNhan; //Field offset: 0x110
	private Int32[] col; //Field offset: 0x118
	private int yLechCmd; //Field offset: 0x120
	private int sizeItem; //Field offset: 0x124
	private long timeBegin; //Field offset: 0x128
	private String[][] strShow; //Field offset: 0x130
	private int gap; //Field offset: 0x138

	private static AuctionScreen() { }

	public AuctionScreen(mVector vec) { }

	public static void addEffectNumImage(string content, int x, int y, sbyte typeColor, FrameImage fra, int frame) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintBg(mGraphics g) { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wpaint) { }

	public virtual void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public virtual void setCamera() { }

	public void SetNewValueDauGia(sbyte id, short idPlayer, int curPrice, int time) { }

	public virtual void update() { }

	public virtual void updatePointer() { }

}

