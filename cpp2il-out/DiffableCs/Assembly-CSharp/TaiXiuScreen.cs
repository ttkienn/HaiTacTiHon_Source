//Type is in global namespace

public class TaiXiuScreen : LuckyScreen
{
	public static TaiXiuScreen instance; //Field offset: 0x0
	public string nameList; //Field offset: 0x110
	private int x; //Field offset: 0x118
	private int y; //Field offset: 0x11C
	private int w; //Field offset: 0x120
	private int h; //Field offset: 0x124
	private iCommand cmdClose; //Field offset: 0x128
	private iCommand cmdDatCuoc; //Field offset: 0x130
	private iCommand cmdTatTay; //Field offset: 0x138
	private iCommand cmdCuocTai; //Field offset: 0x140
	private iCommand cmdCuocXiu; //Field offset: 0x148
	private iCommand cmdDatCuocTai; //Field offset: 0x150
	private iCommand cmdDatCuocXiu; //Field offset: 0x158
	private iCommand cmdTTTai; //Field offset: 0x160
	private iCommand cmdTTXiu; //Field offset: 0x168
	private iCommand cmdTTT1m; //Field offset: 0x170
	private iCommand cmdTTT2m; //Field offset: 0x178
	private iCommand cmdTTT3m; //Field offset: 0x180
	private iCommand cmdTTT4m; //Field offset: 0x188
	private iCommand cmdTTT5m; //Field offset: 0x190
	private iCommand cmdTTT10m; //Field offset: 0x198
	private iCommand cmdTTT20m; //Field offset: 0x1A0
	private iCommand cmdTTX1m; //Field offset: 0x1A8
	private iCommand cmdTTX2m; //Field offset: 0x1B0
	private iCommand cmdTTX3m; //Field offset: 0x1B8
	private iCommand cmdTTX4m; //Field offset: 0x1C0
	private iCommand cmdTTX5m; //Field offset: 0x1C8
	private iCommand cmdTTX10m; //Field offset: 0x1D0
	private iCommand cmdTTX20m; //Field offset: 0x1D8
	private FrameImage fraTaiXiu; //Field offset: 0x1E0
	private FrameImage fraXucXac; //Field offset: 0x1E8
	private int tongTienTai; //Field offset: 0x1F0
	private int tongTienXiu; //Field offset: 0x1F4
	private int daCuoc; //Field offset: 0x1F8
	private short countDown; //Field offset: 0x1FC
	private sbyte cua; //Field offset: 0x1FE
	private sbyte kq; //Field offset: 0x1FF
	private sbyte x1; //Field offset: 0x200
	private sbyte x2; //Field offset: 0x201
	private sbyte x3; //Field offset: 0x202
	private InputDialog input; //Field offset: 0x208
	private long timeBegin; //Field offset: 0x210
	private long timeUpdate; //Field offset: 0x218
	public bool isEffKq; //Field offset: 0x220
	private bool isSendSv; //Field offset: 0x221
	private int indexShowKq; //Field offset: 0x224
	private int index1; //Field offset: 0x228
	private int index2; //Field offset: 0x22C
	private int index3; //Field offset: 0x230

	public TaiXiuScreen(string name, int tongTai, int tongXiu, int daCuoc, sbyte cua, short time) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void createEff(short type, int subtype, int x, int y, int xto, int yto) { }

	private void IncreaseIndexShowKq() { }

	public virtual void paint(mGraphics g) { }

	public void SetDatCuoc(int tongTai, int tongXiu, int daCuoc, sbyte cua) { }

	public void SetUpdateTaiXiu(int tongTai, int tongXiu) { }

	public void SetXucXac(sbyte kq, sbyte x1, sbyte x2, sbyte x3, bool isEff) { }

	public virtual void update() { }

	public virtual void updatePointer() { }

	public virtual void UpdateStepQuaySo() { }

}

