//Type is in global namespace

public class QuayOcSenScreen : LuckyScreen
{
	public const sbyte STEP_SHOW_KETQUA = 5; //Field offset: 0x0
	public const sbyte TYPE_XOAY_RUBY = 3; //Field offset: 0x0
	public const sbyte TYPE_XOAY_OC_SEN = 4; //Field offset: 0x0
	public static QuayOcSenScreen instance; //Field offset: 0x0
	private static mImage imgPhatSang; //Field offset: 0x8
	private static mImage imgOcSen; //Field offset: 0x10
	private iCommand cmdQuayOcSen; //Field offset: 0x110
	private sbyte indexQuaySo; //Field offset: 0x118
	private bool isClockwise; //Field offset: 0x119
	private SByte[] mNhan; //Field offset: 0x120
	public string title; //Field offset: 0x128
	private int countRemainGift; //Field offset: 0x130
	private MainItem vequay; //Field offset: 0x138

	public QuayOcSenScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void IncreaseIndexShowPotion() { }

	public virtual void loadImgVongQuay() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintVongQuay(mGraphics g) { }

	public void SetIndexQuaySo(sbyte index) { }

	public void SetmNhan(SByte[] m) { }

	public virtual void setPosPotion() { }

	public virtual int updateNumve() { }

	public virtual void UpdateStepQuaySo() { }

}

