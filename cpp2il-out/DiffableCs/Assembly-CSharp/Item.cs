//Type is in global namespace

public class Item : MainItem
{
	public static mVector vecItemKichAnCheckInfo; //Field offset: 0x0
	private MainInfoItem[] mInfoItemSave; //Field offset: 0xC8

	private static Item() { }

	public Item(sbyte typeItem, short ID, short idIcon, string name, sbyte isTrade) { }

	public Item(sbyte typeItem, short ID, short idIcon, string name, short timeUse, short maxTimeUse, short ruby) { }

	public static void CheckAddDataKichAn() { }

	public virtual mVector getActionChest() { }

	public virtual mVector getActionInven(sbyte type) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual mVector getActionSplit() { }

	public virtual mVector getActionUpgrade() { }

	public virtual MainImage getImage() { }

	public MainImage getImageRuong() { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

	public void paintRuong(mGraphics g, int x, int y, int w) { }

	public void setDataItem(short Lv, sbyte charClass, sbyte colorName, int timeUse, sbyte typeEquip, sbyte LvUp, sbyte numLoKham, Int16[] mdakham, short valueChetac, sbyte isHoanMy, sbyte valueKichAn) { }

	public void setInfoItem(MainInfoItem[] mInfoItem, int sizeMainInfo) { }

	public void setInfoItemSell(MainInfoItem[] mInfoItem) { }

	public virtual void setTimeMarket(int time) { }

}

