//Type is in global namespace

public class TabShop : MainTabShop
{
	public static iCommand cmdBuyItem; //Field offset: 0x0
	public static iCommand cmdBuyPotion; //Field offset: 0x8
	public static iCommand cmdShip; //Field offset: 0x10
	public static iCommand cmdChangeShip; //Field offset: 0x18
	public static iCommand cmdUse; //Field offset: 0x20
	public static iCommand cmdDonotUse; //Field offset: 0x28
	public static iCommand cmdBuyHair; //Field offset: 0x30
	public static iCommand cmdBuyIconClan; //Field offset: 0x38
	public static iCommand cmdOpenRebuildItem; //Field offset: 0x40
	public static iCommand cmdOpenMenuDaKham; //Field offset: 0x48
	public static MainObject objPaint; //Field offset: 0x50
	public bool isSelect; //Field offset: 0xE0
	private Int32[] mNumBuyRuby; //Field offset: 0xE8
	private short hairEff; //Field offset: 0xF0
	private short demhairEff; //Field offset: 0xF2

	private static TabShop() { }

	public TabShop(string name, mVector vec, sbyte typeShop, int xTab) { }

	public void addWearingFashion(int type, Int16[] mwearing) { }

	public void addWearingHair(int type, int value) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual iCommand getCmdLeft() { }

	public virtual mVector getMenuActionItem() { }

	private void getMenuDaKham() { }

	public void initCmd() { }

	public virtual void paintItemCur(mGraphics g, MainItem Item, int x, int y) { }

	public virtual void paintShowBoat(mGraphics g, int x, int y) { }

	public virtual void updateBuyItem(short id, sbyte type) { }

	public virtual void updateInshop() { }

	public virtual void updateTrangBi() { }

}

