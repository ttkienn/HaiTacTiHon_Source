//Type is in global namespace

public class TradeScreen : ScreenUpgrade
{
	public static TradeScreen instance; //Field offset: 0x0
	public MainObject objMain; //Field offset: 0x1D0
	public MainObject objTrade; //Field offset: 0x1D8
	private Int32[][] posName_Money; //Field offset: 0x1E0
	private iCommand cmdTradeMoney; //Field offset: 0x1E8
	private iCommand cmdLock; //Field offset: 0x1F0
	private iCommand cmdTrade; //Field offset: 0x1F8
	private iCommand cmdChat; //Field offset: 0x200
	private iCommand cmdCancel; //Field offset: 0x208
	private iCommand cmdMenu; //Field offset: 0x210
	private InputDialog input; //Field offset: 0x218
	private int xtest; //Field offset: 0x220
	private int ytest; //Field offset: 0x224

	public TradeScreen(sbyte typeRebuild, int size) { }

	public void addChat(string str, MainObject obj) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void getItemCurNew() { }

	public void getMenu() { }

	public virtual mVector getMenuActionItem() { }

	public virtual bool isGetItemUpgrade(short Id, sbyte cat) { }

	public virtual bool keyBack() { }

	public virtual void paintChat(mGraphics g) { }

	public virtual void paintIconUpgrade(mGraphics g, int x, int y, MainItem item) { }

	public virtual void paintlockTrade(mGraphics g, MainItem item, int x, int y) { }

	public virtual void paintPosItem(mGraphics g) { }

	public virtual void paintTrade(mGraphics g) { }

	public bool setCurrentInTrade(MainItem item) { }

	public void setItem(sbyte ai, sbyte action, MainItem item) { }

	public void setLock() { }

	public void setNameObjTrade(string name) { }

	public virtual void setPosCmd(mVector vec) { }

	public virtual void setPosInfo() { }

	private void setSmallCmd() { }

	public virtual void setStart(sbyte typeRe, int size) { }

	public virtual void setStep() { }

	public void setTrade() { }

	public virtual void update() { }

	public void updateChatPopup(MainObject obj) { }

	public virtual void updatekey() { }

	public virtual void updateNewUpgrade() { }

	public virtual void updatePointer() { }

}

