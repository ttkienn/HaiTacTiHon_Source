//Type is in global namespace

public class MsgSound : MsgDialog
{
	private bool isMusicCur; //Field offset: 0x138

	public MsgSound() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public void setinfoSound() { }

	public void setSelect() { }

	public void stopMusic() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

