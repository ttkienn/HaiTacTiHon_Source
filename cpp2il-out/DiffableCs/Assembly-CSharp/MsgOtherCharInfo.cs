//Type is in global namespace

public class MsgOtherCharInfo : MsgDialog
{
	public static InfoMemList infoFight; //Field offset: 0x0
	private MainObject obj; //Field offset: 0x138
	private int sizeBanner; //Field offset: 0x140
	private int timeShowInfo; //Field offset: 0x144
	private Int32[][] mposEquip; //Field offset: 0x148
	private MainItem itemCur; //Field offset: 0x150
	private int xInfo; //Field offset: 0x158
	private int yInfo; //Field offset: 0x15C
	private int ylechthanhtich; //Field offset: 0x160
	private int yLechChar; //Field offset: 0x164
	private bool isShowInfo; //Field offset: 0x168
	private bool isCheckTop; //Field offset: 0x169
	private iCommand cmdfight; //Field offset: 0x170
	private int lastTick; //Field offset: 0x178
	private int framepaint; //Field offset: 0x17C

	public MsgOtherCharInfo(MainObject obj) { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void doMenu() { }

	public virtual void paint(mGraphics g) { }

	public void setPosInfo(MainItem item, int xbe, int ybe) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

