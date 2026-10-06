//Type is in global namespace

public class MsgSpamSetup : MsgDialog
{
	public static Int32[] valueSetup; //Field offset: 0x0
	public const sbyte CHECK_CHAT = 1; //Field offset: 0x0
	public const sbyte CHECK_ADD_FRIEND = 2; //Field offset: 0x0
	public const sbyte CHECK_PARTY = 3; //Field offset: 0x0
	public const sbyte CHECK_TRADE = 4; //Field offset: 0x0
	public const sbyte CHECK_FIGHT = 5; //Field offset: 0x0
	public static bool isDontShowFriendList; //Field offset: 0x8
	private int hItem; //Field offset: 0x138

	public MsgSpamSetup() { }

	public static bool isCheckSpam(int index, string str) { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public static void saveClose() { }

	public void setinfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

