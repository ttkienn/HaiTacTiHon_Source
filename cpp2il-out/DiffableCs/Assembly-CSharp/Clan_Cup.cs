//Type is in global namespace

public class Clan_Cup : ChatDetail
{
	private int minChat; //Field offset: 0xC0
	private int maxChat; //Field offset: 0xC4

	public Clan_Cup(string name, sbyte type) { }

	public void addOneChat(short IDChat, short IDMem, string name, string str, sbyte typeAction, long time) { }

	public virtual void addStringClan(short ID, string str, string nametext, string textRight, sbyte typeBg, sbyte IDEvent, short IdMem, long time) { }

	public virtual void beginFocus() { }

	public virtual void paint(mGraphics g) { }

	public virtual void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	private void setXCam() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updateTime() { }

}

