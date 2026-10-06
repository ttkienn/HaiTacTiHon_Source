//Type is in global namespace

public class MsgArchiDaily : MsgDialog
{
	public static mVector vecArchi; //Field offset: 0x0
	private iCommand cmdReward; //Field offset: 0x138

	private static MsgArchiDaily() { }

	public MsgArchiDaily() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void getCmd() { }

	public virtual void paint(mGraphics g) { }

	public void setClip(mGraphics g) { }

	private void setFocus(int value) { }

	public void setinfo(string name, mVector vec) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

