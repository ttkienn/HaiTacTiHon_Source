//Type is in global namespace

public class MsgShowGift : MsgDialog
{
	public const sbyte OPEN_BOX_WANTED_THANTHOAI = 15; //Field offset: 0x0
	public const sbyte SHOW_OPEN_RUONG = 1; //Field offset: 0x0
	public const sbyte SHOW_GIFT = 2; //Field offset: 0x0
	public const sbyte OPEN_BOX_TYPE_ITEM_DROP_2 = 24; //Field offset: 0x0
	public const sbyte OPEN_BOX_TYPE_ITEM_DROP = 23; //Field offset: 0x0
	public const sbyte OPEN_BOX_ON_HEAD = 22; //Field offset: 0x0
	public const sbyte OPEN_BOX_VIP = 21; //Field offset: 0x0
	public const sbyte OPEN_BOX_QUAY_SO = 20; //Field offset: 0x0
	public const sbyte SHOW_RUONG = 0; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED_SIEUMATHUAT = 14; //Field offset: 0x0
	public static MainItem gift; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED_MATHUAT = 12; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED_VANG = 11; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED_GO = 10; //Field offset: 0x0
	public const sbyte GIFT_CHEST_WANTED = 3; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED = 2; //Field offset: 0x0
	public const sbyte OPEN_BOX = 1; //Field offset: 0x0
	public const sbyte GIFT_QUEST = 0; //Field offset: 0x0
	public const sbyte OPEN_BOX_WANTED_KHONGLO = 13; //Field offset: 0x0
	public static Int32[] colorBorder; //Field offset: 0x8
	public static Int32[] colorBorderVongQuay; //Field offset: 0x10
	private Item_Drop[] mItemgift; //Field offset: 0x138
	private string strphanthuong; //Field offset: 0x140
	private MainObject objPaint; //Field offset: 0x148
	private int indexShowItemBox; //Field offset: 0x150
	private int timeShowEff; //Field offset: 0x154
	private int yShowEff; //Field offset: 0x158
	private int speed; //Field offset: 0x15C
	private int countClose; //Field offset: 0x160
	private int timeClose; //Field offset: 0x164
	private short idChest; //Field offset: 0x168
	private FrameImage fraRuongVip; //Field offset: 0x170
	private sbyte typeBanner; //Field offset: 0x178
	private sbyte indexShow; //Field offset: 0x179
	public int xCloseQuickOpen; //Field offset: 0x17C
	public int yCloseQuickOpen; //Field offset: 0x180
	private Int32[][] mShowRuongVip; //Field offset: 0x188

	private static MsgShowGift() { }

	public MsgShowGift() { }

	private bool checkRuongInInventory() { }

	private void loadmImg() { }

	public virtual void paint(mGraphics g) { }

	public void paintBanner(mGraphics g) { }

	private void paintItemNormal(mGraphics g, int ypaint) { }

	private void paintItemQuaySo(mGraphics g, int ypaint) { }

	private void paintShowVip(mGraphics g) { }

	public void setCmdList(mVector vecCmd) { }

	public void setinfoShow_Gift(sbyte type, string name, string info, Item_Drop[] mitem, short IdChest) { }

	public void setinfoShow_Gift_OnHead(sbyte type, string name, string info, Item_Drop[] mitem, short IdChest, MainObject obj) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updatePointerQuickOpenPotion() { }

}

