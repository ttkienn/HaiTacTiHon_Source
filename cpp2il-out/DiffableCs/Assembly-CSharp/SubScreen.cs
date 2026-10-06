//Type is in global namespace

public class SubScreen : MainScreen
{
	public sbyte type; //Field offset: 0x50
	public int xSub; //Field offset: 0x54
	public int ySub; //Field offset: 0x58
	public int wSub; //Field offset: 0x5C
	public int hSub; //Field offset: 0x60
	public int hItem; //Field offset: 0x64
	public int xBegin; //Field offset: 0x68
	public int w2cmd; //Field offset: 0x6C

	public SubScreen(sbyte type) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public override void setPosCmdNew(int yplus, mVector vecMenu) { }

	public void setPosVecMenu(mVector vecMenu) { }

	public virtual void setxyPlus12() { }

}

