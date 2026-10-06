//Type is in global namespace

public class MsgUpdateHeart : ScreenUpgrade
{
	public static MsgUpdateHeart instance; //Field offset: 0x0
	public const sbyte STEP_NORMAL = 0; //Field offset: 0x0
	public const sbyte STEP_UPGRADE = 1; //Field offset: 0x0
	public const sbyte STEP_WAIT_UPGRADE = 2; //Field offset: 0x0
	private string text; //Field offset: 0x1D0
	private MainItem itemHeart; //Field offset: 0x1D8
	private int ylech; //Field offset: 0x1E0
	private iCommand cmdUpgrade; //Field offset: 0x1E8
	private Int32[] mplayFrameNormal; //Field offset: 0x1F0
	private Int32[] mplayFrameUpgrade; //Field offset: 0x1F8
	private int stepUpgrade; //Field offset: 0x200
	private int playHeart; //Field offset: 0x204
	private int play1_0; //Field offset: 0x208
	private int play1_1; //Field offset: 0x20C
	private int play1_2; //Field offset: 0x210
	private int play1_3; //Field offset: 0x214
	private int play2; //Field offset: 0x218
	private int play3_0; //Field offset: 0x21C
	private int play3_1; //Field offset: 0x220
	private int play4_0; //Field offset: 0x224
	private int play4_1; //Field offset: 0x228
	private int play4_2; //Field offset: 0x22C
	private int play4_3; //Field offset: 0x230

	public MsgUpdateHeart() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	private void paintInfoHeart(mGraphics g) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updateStepUpgrade(sbyte type, string text) { }

}

