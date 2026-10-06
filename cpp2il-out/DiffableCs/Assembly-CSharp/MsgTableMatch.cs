//Type is in global namespace

public class MsgTableMatch : MsgDialog
{
	public mVector vecMatch; //Field offset: 0x138

	public MsgTableMatch() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setinfo(mVector vec) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

