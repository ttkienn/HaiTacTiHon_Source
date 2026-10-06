//Type is in global namespace

public class Clan_Mem : ChatDetail
{
	public static int tickupdate; //Field offset: 0x0
	private iCommand cmdView; //Field offset: 0xC0
	private iCommand cmdUpdate; //Field offset: 0xC8
	private int minChat; //Field offset: 0xD0
	private int maxChat; //Field offset: 0xD4

	public Clan_Mem(string name, sbyte type) { }

	public virtual void beginFocus() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void doMenuTouchPlayer() { }

	public virtual void paint(mGraphics g) { }

	public void setDataCam() { }

	public virtual void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	private void setXCam() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public void updateLimCam() { }

	public virtual void updatePointer() { }

}

