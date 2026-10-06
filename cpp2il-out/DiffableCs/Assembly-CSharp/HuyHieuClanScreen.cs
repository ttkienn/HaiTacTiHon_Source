//Type is in global namespace

public class HuyHieuClanScreen : LuckyScreen
{
	public static HuyHieuClanScreen instance; //Field offset: 0x0
	private static mImage[] mImgHuyHieu; //Field offset: 0x8
	public static int numXuInput; //Field offset: 0x10
	public static bool isRunningOpenXu; //Field offset: 0x14
	private FrameImage fraRuong; //Field offset: 0x110
	public MainItem potionQuay; //Field offset: 0x118
	public Potion potionNhan; //Field offset: 0x120
	public bool isThanhCong; //Field offset: 0x128
	public InputDialog input; //Field offset: 0x130
	public bool isContinue; //Field offset: 0x138
	private MainImage imgNhan; //Field offset: 0x140
	private FrameImage fraNhan; //Field offset: 0x148
	private int tickRuong; //Field offset: 0x150

	private static HuyHieuClanScreen() { }

	public HuyHieuClanScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void createEff(short type, int subtype, int x, int y, int xto, int yto) { }

	public void cShowQuickOpenXu() { }

	public virtual void loadImgVongQuay() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintVongQuay(mGraphics g) { }

	public void showQuickOpenXu() { }

	public void stopOpenXu() { }

	public void updatePointerOpenXu() { }

	public virtual void UpdateStepQuaySo() { }

}

