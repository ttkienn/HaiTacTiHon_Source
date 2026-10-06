//Type is in global namespace

public class Item_Drop : MainObject
{
	public static Item_Drop currentSelectItemDrop; //Field offset: 0x0
	public const sbyte GIFT_DAILY_CURRENT = 1; //Field offset: 0x0
	public const sbyte GIFT_DAILY_NORMAL = 0; //Field offset: 0x0
	public const sbyte GIFT_DAILY_GOT = 2; //Field offset: 0x0
	public const sbyte GIFT_DAILY_MISS = 3; //Field offset: 0x0
	public static MainImage imgDefault; //Field offset: 0x8
	public static MainImage imgMainIconXp; //Field offset: 0x10
	private long timeAp; //Field offset: 0x468
	private int timefly; //Field offset: 0x470
	private int timeDrop; //Field offset: 0x474
	private int timeStopDrop; //Field offset: 0x478
	private int timeGet; //Field offset: 0x47C
	public sbyte typeDrop; //Field offset: 0x480
	public sbyte typeGiftDaily; //Field offset: 0x481
	public int num; //Field offset: 0x484
	private bool isUpdateDrop; //Field offset: 0x488
	private bool isLittlegarden; //Field offset: 0x489
	public FrameImage fraImgVip; //Field offset: 0x490
	public bool isloadfra; //Field offset: 0x498

	public Item_Drop(short ID, sbyte type, string name, int x, int y, short IdIcon, sbyte color) { }

	public Item_Drop(short ID, sbyte type, string name, int x, int y, short IdIcon, sbyte color, int xto, int yto) { }

	private bool checkXp() { }

	public Point_Focus create_Speed(int xdich, int ydich, Point_Focus p) { }

	public MainImage getImg() { }

	public virtual void paint(mGraphics g) { }

	public void paintAvatarFocus(mGraphics g, int xp, int yp) { }

	public virtual void paintInfoFocus(mGraphics g, int xp, int yp) { }

	public virtual void paintName(mGraphics g, sbyte color, int isFocus) { }

	public void paintXY(mGraphics g, int x, int y) { }

	public virtual void setFireObject(int value) { }

	private void setFraImageVip(MainImage img) { }

	public void setOpenBox() { }

	public virtual void setTouchPoint() { }

	public void setVx_Vy_Item() { }

	public void setVx_Vy_ItemLittle() { }

	public virtual void update() { }

	public virtual void updateDySea() { }

}

