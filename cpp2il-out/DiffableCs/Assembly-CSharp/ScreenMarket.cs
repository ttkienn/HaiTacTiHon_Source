//Type is in global namespace

public class ScreenMarket : MainTab
{
	public const sbyte INDEX_MARKET_POTION = 6; //Field offset: 0x0
	public const sbyte INDEX_MARKET_INVEN = 4; //Field offset: 0x0
	public const sbyte INDEX_MARKET_CHEST = 3; //Field offset: 0x0
	public const sbyte INDEX_MARKET_SUC = 2; //Field offset: 0x0
	public const sbyte INDEX_MARKET_AO = 1; //Field offset: 0x0
	public const sbyte INDEX_MARKET_WEA = 0; //Field offset: 0x0
	public const sbyte INDEX_MARKET_NGUYEN_LIEU = 5; //Field offset: 0x0
	private mVector vecList; //Field offset: 0x88
	private ListNew list; //Field offset: 0x90
	private int maxPaint; //Field offset: 0x98
	public MainItem itemCur; //Field offset: 0xA0
	public mVector vecCmd; //Field offset: 0xA8
	public mVector vecInfoSS; //Field offset: 0xB0
	public iCommand cmdBuy; //Field offset: 0xB8
	public iCommand cmdSelectPage; //Field offset: 0xC0
	public iCommand cmdClose; //Field offset: 0xC8
	public iCommand cmdSell; //Field offset: 0xD0
	public iCommand cmdGet; //Field offset: 0xD8
	public iCommand cmdUpdate; //Field offset: 0xE0
	public iCommand cmdMenu; //Field offset: 0xE8
	public iCommand cmdCancleSell; //Field offset: 0xF0
	public iCommand cmdPlusItem; //Field offset: 0xF8
	private InputDialog input; //Field offset: 0x100
	private TabScreen ScrTab; //Field offset: 0x108

	public ScreenMarket(string nameTab, mVector vec, TabScreen tab, sbyte indexMarket) { }

	public void addButtonPlus() { }

	public virtual void beginFocus() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void getCmd() { }

	public sbyte getIndexMarket() { }

	public void getItemCurNew() { }

	public virtual void paint(mGraphics g) { }

	public void setClip(mGraphics g) { }

	public void setCreateCmd() { }

	public virtual void setData(mVector vec) { }

	private void setIconTab() { }

	public virtual void setPosInfo() { }

	public virtual void update() { }

	public virtual void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public virtual void updateShowInfo() { }

}

