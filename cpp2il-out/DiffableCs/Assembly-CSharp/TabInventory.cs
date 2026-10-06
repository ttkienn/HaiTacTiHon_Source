//Type is in global namespace

public class TabInventory : MainTabShop
{
	public static iCommand cmdSellWhite; //Field offset: 0x0
	public static iCommand cmdSell_W_G; //Field offset: 0x8
	public static iCommand cmdSellMore; //Field offset: 0x10
	public static short priceItemSell; //Field offset: 0x18
	public static short maxPriceItemSell; //Field offset: 0x1A
	public static short pricePotionSell; //Field offset: 0x1C
	public static int numPotionTemp; //Field offset: 0x20
	public static int numPotionInput; //Field offset: 0x24
	public static short focusIDItem; //Field offset: 0x28
	public static short numSell; //Field offset: 0x2A
	public static mVector vecsell; //Field offset: 0x30
	public static int LvUpgradeSS; //Field offset: 0x38
	private sbyte typeInventory; //Field offset: 0xE0
	public iCommand cmdUsePotion; //Field offset: 0xE8
	public iCommand cmdSetHotKey; //Field offset: 0xF0
	public iCommand cmdUseItem; //Field offset: 0xF8
	public iCommand cmdRemoveItem; //Field offset: 0x100
	public iCommand cmdSellItem; //Field offset: 0x108
	public iCommand cmdSetChestItem; //Field offset: 0x110
	public iCommand cmdSetChestPotion; //Field offset: 0x118
	public iCommand cmdSellAll; //Field offset: 0x120
	public iCommand cmdUpgradeItem; //Field offset: 0x128
	public iCommand cmdAutoMaterial; //Field offset: 0x130
	public iCommand cmdAllMaterial; //Field offset: 0x138
	public iCommand cmdChucnang; //Field offset: 0x140
	public iCommand cmdMenuMaterial; //Field offset: 0x148
	public iCommand cmdMenuSellShop; //Field offset: 0x150
	public iCommand cmdSellMarket; //Field offset: 0x158
	public iCommand cmdAllDiamond; //Field offset: 0x160
	public iCommand cmdSellBeri; //Field offset: 0x168
	public iCommand cmdDonotUse; //Field offset: 0x170
	public iCommand cmdUseFastPotion; //Field offset: 0x178

	private static TabInventory() { }

	public TabInventory(string name, mVector vec, sbyte typeInventory, int xTab) { }

	public virtual void addButtonPlus() { }

	public bool checkFullItem() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void cShowQuickOpenPotion() { }

	public virtual mVector getMenuActionItem() { }

	private void getMenuHotKey() { }

	public void initCmd() { }

	public virtual void resize(int max) { }

	public static void Sell_W(mVector vec) { }

	public static void Sell_W_G(mVector vec) { }

	public static void SellMore() { }

	public void setTypeInven(sbyte type) { }

	public void showQuickOpenPotion() { }

	public void Use(short idIcon) { }

}

