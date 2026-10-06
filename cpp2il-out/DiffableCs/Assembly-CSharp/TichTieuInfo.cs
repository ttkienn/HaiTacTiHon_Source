//Type is in global namespace

public class TichTieuInfo : SubScreen
{
	public static TichTieuInfo instance; //Field offset: 0x0
	private ListNew list; //Field offset: 0x70
	private InfoMemList mem; //Field offset: 0x78
	private iCommand cmdClose; //Field offset: 0x80
	private iCommand cmdNhan; //Field offset: 0x88
	private mVector vecMenu; //Field offset: 0x90
	private int idCommand; //Field offset: 0x98
	private int idSelect; //Field offset: 0x9C
	private int hContent; //Field offset: 0xA0
	private int miniItem; //Field offset: 0xA4
	private Scroll scroll; //Field offset: 0xA8

	public TichTieuInfo(sbyte type, InfoMemList mem) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	private void paintBg(mGraphics g, int xpaint, int ypaint) { }

	private void paintInfo(mGraphics g, int xpaint, int ypaint) { }

	private void setClip(mGraphics g) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

