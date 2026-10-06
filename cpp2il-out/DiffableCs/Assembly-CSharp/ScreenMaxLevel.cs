//Type is in global namespace

public class ScreenMaxLevel : MainScreen
{
	public static ScreenMaxLevel instance; //Field offset: 0x0
	private int w; //Field offset: 0x50
	private int h; //Field offset: 0x54
	private int x; //Field offset: 0x58
	private int y; //Field offset: 0x5C
	private int wItemCur; //Field offset: 0x60
	private int idSelect; //Field offset: 0x64
	public ListNew list; //Field offset: 0x68
	private iCommand cmdClose; //Field offset: 0x70

	public ScreenMaxLevel() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public static ScreenMaxLevel gI() { }

	public virtual void paint(mGraphics g) { }

	private void setAction(int ac) { }

	public void setData() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

