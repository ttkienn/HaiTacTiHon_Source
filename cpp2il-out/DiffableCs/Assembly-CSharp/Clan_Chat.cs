//Type is in global namespace

public class Clan_Chat : ChatDetail
{
	public const sbyte EVENT_CHAT = -1; //Field offset: 0x0
	public const sbyte EVENT_XIN_VAO_CLAN = 1; //Field offset: 0x0
	public const sbyte EVENT_MAU_DO = -2; //Field offset: 0x0
	public const sbyte EVENT_THONG_BAO = -3; //Field offset: 0x0
	public const sbyte EVENT_DONATE = -4; //Field offset: 0x0
	private iCommand cmdView; //Field offset: 0xC0
	private iCommand cmdChoVaoClan; //Field offset: 0xC8
	private iCommand cmdTuChoiVaoClan; //Field offset: 0xD0
	private iCommand cmdChat; //Field offset: 0xD8
	private InfoMemList memCur; //Field offset: 0xE0
	private MainTextChat chatCur; //Field offset: 0xE8
	private int minChat; //Field offset: 0xF0
	private int maxChat; //Field offset: 0xF4

	public Clan_Chat(string name, sbyte type) { }

	public void addOneChat(short IDChat, short IDMem, string name, string str, sbyte typeAction, long time) { }

	public virtual void addStringClan(short ID, string str, string nametext, string textRight, sbyte typeBg, sbyte IDEvent, short IdMem, long time) { }

	public virtual void beginFocus() { }

	public void checkRemoveChat() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void getCmdEvent() { }

	public virtual void paint(mGraphics g) { }

	public void RemoveChat(short id) { }

	private void setEvent() { }

	public virtual void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	private void setXCam() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updateTime() { }

}

