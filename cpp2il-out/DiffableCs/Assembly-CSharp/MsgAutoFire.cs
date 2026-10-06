//Type is in global namespace

public class MsgAutoFire : MsgDialog
{
	public static Int16[][] value; //Field offset: 0x0
	private int hItem; //Field offset: 0x138
	private int valueFire; //Field offset: 0x13C
	private int valueRevice; //Field offset: 0x140
	private int xbeginSkill; //Field offset: 0x144
	private int xbeginBuff; //Field offset: 0x148
	private int indexBuff; //Field offset: 0x14C
	private iCommand cmdOK; //Field offset: 0x150

	public MsgAutoFire() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus, int hFocus) { }

	public void setinfoAuto_Fire() { }

	public void setSelect(int plus) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

