//Type is in global namespace

public class ScreenDoiQua : MainScreen
{
	public static ScreenDoiQua _instance; //Field offset: 0x0
	private int x; //Field offset: 0x50
	private int y; //Field offset: 0x54
	private int w; //Field offset: 0x58
	private int h; //Field offset: 0x5C
	private int wItem; //Field offset: 0x60
	private int wsai; //Field offset: 0x64
	public mVector vecItemLose; //Field offset: 0x68
	public mVector vecItemGif; //Field offset: 0x70
	private mVector vecEff; //Field offset: 0x78
	private Int32[] PosX; //Field offset: 0x80
	private Int32[] PosY; //Field offset: 0x88
	public sbyte Focus; //Field offset: 0x90
	public sbyte Type_Focus; //Field offset: 0x91
	public mVector vecCmd; //Field offset: 0x98
	public iCommand cmdClose; //Field offset: 0xA0
	public iCommand cmdNhan; //Field offset: 0xA8

	public ScreenDoiQua() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void createEff(short type, int subtype, int x, int y, int xto, int yto) { }

	public static ScreenDoiQua instance() { }

	public virtual bool keyBack() { }

	public virtual void paint(mGraphics g) { }

	public void paintBackGr(mGraphics g) { }

	public void paintEff(mGraphics g, int level) { }

	public virtual void update() { }

	public void updateEff() { }

	public virtual void updatePointer() { }

}

