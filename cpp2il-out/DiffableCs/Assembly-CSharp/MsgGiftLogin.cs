//Type is in global namespace

public class MsgGiftLogin : MsgDialog
{
	public static sbyte TYPE_DAILY_GIFT; //Field offset: 0x0
	public static sbyte TYPE_BOX_CHOICE; //Field offset: 0x1
	private Item_Drop[] mItemgift; //Field offset: 0x138
	private int wItemInterface; //Field offset: 0x140
	private MainItem itemMain; //Field offset: 0x148

	private static MsgGiftLogin() { }

	public MsgGiftLogin() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	private void paintBanner(mGraphics g) { }

	public void setinfoShow_GiftLogin(sbyte type, string name, string info, Item_Drop[] mitem, sbyte action, string nameCmd, MainItem itemMain) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

