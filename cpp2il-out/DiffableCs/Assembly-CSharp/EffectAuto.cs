//Type is in global namespace

public class EffectAuto : MainItemMap
{
	public static long timeSoundFIRE; //Field offset: 0x0
	public static long timeSoundWATER; //Field offset: 0x8
	public static long timeSoundPHUNNUOC; //Field offset: 0x10
	public static long timeSoundGIOTNUOC; //Field offset: 0x18
	private MainEffectAuto eff; //Field offset: 0x488
	private int nCountReplay; //Field offset: 0x490
	private bool isPaint; //Field offset: 0x494
	private int typeEffect; //Field offset: 0x498
	private int valueEffect; //Field offset: 0x49C
	private long timeBegin; //Field offset: 0x4A0
	private int indexSound; //Field offset: 0x4A8
	private int timePlaySound; //Field offset: 0x4AC
	private int tickupdate; //Field offset: 0x4B0

	public EffectAuto(string keystr, string value) { }

	public MainEffectAuto checkLoadRMS(short id) { }

	public MainEffectAuto loadTemEff(short id) { }

	public virtual void paint(mGraphics g) { }

	public static MainEffectAuto readData(SByte[] dataeff, bool isSave) { }

	public static void saveDataEffAuto(SByte[] dataSave, short id) { }

	private void setBeginSound() { }

	public void setDataEff() { }

	public void setPlaySound() { }

	public virtual void update() { }

}

