//Type is in global namespace

public class MsgAutoMPHP : MsgDialog
{
	public static int mp; //Field offset: 0x0
	public static int hp; //Field offset: 0x4
	public static int typeUu; //Field offset: 0x8

	private static MsgAutoMPHP() { }

	public MsgAutoMPHP() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public void setinfoAuto_MP_HP() { }

	public void setSelect(int value) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

