//Type is in global namespace

public class LuckyScreen : MainScreen
{
	public const sbyte STEP_WAIT_BEGIN = 0; //Field offset: 0x0
	public const sbyte STEP_BEGIN = 1; //Field offset: 0x0
	public const sbyte STEP_WAIT_QUAY = 2; //Field offset: 0x0
	public const sbyte STEP_QUAY = 3; //Field offset: 0x0
	public const sbyte STEP_KETQUA = 4; //Field offset: 0x0
	public const sbyte TYPE_1 = 0; //Field offset: 0x0
	public const sbyte TYPE_3 = 1; //Field offset: 0x0
	public const short ID_TICKET = 0; //Field offset: 0x0
	public static LuckyScreen instance; //Field offset: 0x0
	public static mImage[] mImgVongquay; //Field offset: 0x8
	public static mVector mListItemLucky; //Field offset: 0x10
	public static bool isUpdateVe; //Field offset: 0x18
	public mVector vecCmd; //Field offset: 0x50
	public mVector vecEff; //Field offset: 0x58
	protected int x; //Field offset: 0x60
	protected int y; //Field offset: 0x64
	protected int w; //Field offset: 0x68
	protected int h; //Field offset: 0x6C
	protected int idSelect; //Field offset: 0x70
	protected int tickVongQuay; //Field offset: 0x74
	protected int xQuay; //Field offset: 0x78
	protected int yQuay; //Field offset: 0x7C
	protected int xButton; //Field offset: 0x80
	protected int yButton; //Field offset: 0x84
	protected int wButton; //Field offset: 0x88
	protected int indexShowPotion; //Field offset: 0x8C
	public int tickAction; //Field offset: 0x90
	public int typeQuay; //Field offset: 0x94
	public int StepQuaySo; //Field offset: 0x98
	protected iCommand cmdClose; //Field offset: 0xA0
	protected iCommand cmdQuay; //Field offset: 0xA8
	protected iCommand cmdQuay3Lan; //Field offset: 0xB0
	protected iCommand cmdBuyTicket; //Field offset: 0xB8
	protected FrameImage fraImgBuy; //Field offset: 0xC0
	protected FrameImage fraImg1Lan; //Field offset: 0xC8
	protected FrameImage fraImg5Lan; //Field offset: 0xD0
	private MainItem poi; //Field offset: 0xD8
	protected Int32[] mPlayVongTrungTam; //Field offset: 0xE0
	protected Int32[] mPlayVongQuayTo; //Field offset: 0xE8
	protected Int32[] mPlayVongQuayNho; //Field offset: 0xF0
	public int indexOffPaint; //Field offset: 0xF8
	private MainItem vequay; //Field offset: 0x100
	public Item_Drop[] mItemShow; //Field offset: 0x108

	public LuckyScreen() { }

	public void addEffectNumImage(string content, int x, int y, sbyte typeColor, FrameImage fra, int frame) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void dataDialog(Item_Drop[] itemLucky) { }

	public override void loadImgVongQuay() { }

	public virtual void paint(mGraphics g) { }

	public void paintEff(mGraphics g, int level) { }

	public override void paintVongQuay(mGraphics g) { }

	public override void setPosPotion() { }

	public void setPotion() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public override int updateNumve() { }

	public virtual void updatePointer() { }

	public override void UpdateStepQuaySo() { }

}

