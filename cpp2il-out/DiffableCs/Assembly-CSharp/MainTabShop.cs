//Type is in global namespace

public class MainTabShop : MainTab
{
	public const sbyte INVENTORY_CHEST = 2; //Field offset: 0x0
	public static MainItem itemShipCur; //Field offset: 0x0
	public const sbyte INVENTORY_PET = 7; //Field offset: 0x0
	public const sbyte INVENTORY_HUYHIEU = 6; //Field offset: 0x0
	public const sbyte INVENTORY_MARKET = 5; //Field offset: 0x0
	public const sbyte INVENTORY_CLAN = 4; //Field offset: 0x0
	public const sbyte INVENTORY = 0; //Field offset: 0x0
	public const sbyte INVENTORY_SHOP = 1; //Field offset: 0x0
	public const sbyte INVENTORY_UPGRADE = 3; //Field offset: 0x0
	public static bool isUpdateItemShip; //Field offset: 0x8
	public static int maxNumItemW; //Field offset: 0xC
	public static int maxNumItemH; //Field offset: 0x10
	public static bool isSortInven; //Field offset: 0x14
	public static MainTabShop instance; //Field offset: 0x18
	public mVector vecShop; //Field offset: 0x88
	public mVector vecInfoSS; //Field offset: 0x90
	public mVector vecCmd; //Field offset: 0x98
	public MainItem itemCur; //Field offset: 0xA0
	public sbyte typeNPCShop; //Field offset: 0xA8
	public iCommand cmdMenu; //Field offset: 0xB0
	public iCommand cmdPlusItem; //Field offset: 0xB8
	public InputDialog input; //Field offset: 0xC0
	public ListNew list; //Field offset: 0xC8
	public Scroll scrShop; //Field offset: 0xD0
	public int tickbuy; //Field offset: 0xD8

	private static MainTabShop() { }

	public MainTabShop(string name, mVector vec) { }

	public MainTabShop(string name, mVector vec, int maxSize, int xbegin) { }

	public override void addButtonPlus() { }

	public virtual void beginFocus() { }

	public override iCommand getCmdLeft() { }

	public override void getItemCurNew() { }

	public override mVector getMenuActionItem() { }

	public virtual void paint(mGraphics g) { }

	public override void paintItemCur(mGraphics g, MainItem Item, int x, int y) { }

	public override void paintShowBoat(mGraphics g, int x, int y) { }

	public override void setPosCmd(mVector vec) { }

	public virtual void setPosInfo() { }

	public virtual void update() { }

	public virtual void updateInfo() { }

	public override void updateInshop() { }

	public override void updateItemShip() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

