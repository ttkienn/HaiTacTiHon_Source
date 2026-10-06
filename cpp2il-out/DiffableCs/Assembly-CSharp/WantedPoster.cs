//Type is in global namespace

public class WantedPoster : SubScreen
{
	public static WantedPoster instance; //Field offset: 0x0
	private InfoMemList mem; //Field offset: 0x70
	private iCommand cmdClose; //Field offset: 0x78
	private iCommand cmdNhan; //Field offset: 0x80
	private iCommand cmdHuy; //Field offset: 0x88
	private iCommand cmdNhanThuong; //Field offset: 0x90
	private iCommand cmdXoa; //Field offset: 0x98
	private mVector vecMenu; //Field offset: 0xA0
	private int idCommand; //Field offset: 0xA8
	private int hCharShow; //Field offset: 0xAC

	public WantedPoster(sbyte type, InfoMemList mem) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	private void paintBg(mGraphics g, int xpaint, int ypaint) { }

	private void paintInfo(mGraphics g, int xpaint, int ypaint, int wpaint, int hpaint) { }

	private void setCharHpaint() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

