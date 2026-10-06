//Type is in global namespace

public class NapTheScreen : PaintListScreen
{
	public const sbyte TYPE_LIST = 0; //Field offset: 0x0
	public const sbyte TYPE_NHAN = 1; //Field offset: 0x0
	public const sbyte TYPE_DA_NHAN = 2; //Field offset: 0x0
	public static NapTheScreen instance; //Field offset: 0x0
	private int rubyDaNap; //Field offset: 0x100
	private mVector vecCmd; //Field offset: 0x108
	private int wCmdNhan; //Field offset: 0x110
	private Scroll scroll; //Field offset: 0x118
	private int wPaintQua; //Field offset: 0x120

	public NapTheScreen(mVector vec, int ruby) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintBg(mGraphics g) { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public virtual void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public virtual void setCamera() { }

	public void setCmdDaNhanIndex(sbyte id) { }

	public virtual void update() { }

	public virtual void updatePointer() { }

}

