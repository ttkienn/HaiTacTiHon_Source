//Type is in global namespace

public class Effect_Spec : MainEffect
{
	public const sbyte CHOANG = 1; //Field offset: 0x0
	public const sbyte DEC_POWER = 18; //Field offset: 0x0
	public const sbyte DEC_DAMAGE = 15; //Field offset: 0x0
	public const sbyte LUA_TOAN_THAN = -2; //Field offset: 0x0
	public const sbyte EFF_CRITICAL_LT = 12; //Field offset: 0x0
	public const sbyte EFF_BAT_TU = 11; //Field offset: 0x0
	public const sbyte TRUNG_DOC = 10; //Field offset: 0x0
	public const sbyte HUT_MANA = 9; //Field offset: 0x0
	public const sbyte LUA_PHAN_DAU = -1; //Field offset: 0x0
	public const sbyte LUA_CHAY = 7; //Field offset: 0x0
	public const sbyte DIEN_GIAT = 6; //Field offset: 0x0
	public const sbyte HOA_MAT = 5; //Field offset: 0x0
	public const sbyte GIAM_PHONG_THU = 4; //Field offset: 0x0
	public const sbyte GIAM_TAN_CONG = 3; //Field offset: 0x0
	public const sbyte CHAY_MAU = 2; //Field offset: 0x0
	public const sbyte TROI_CHAN = 8; //Field offset: 0x0
	private int dy; //Field offset: 0x160
	private int dx; //Field offset: 0x164
	private short timeEff; //Field offset: 0x168
	private mVector vecEff; //Field offset: 0x170
	private String[] mtest; //Field offset: 0x178
	private Int32[][] mPlayFrameVip; //Field offset: 0x180
	private Int32[] mPlayframe; //Field offset: 0x188
	private Point pMain; //Field offset: 0x190
	private int tick; //Field offset: 0x198

	public Effect_Spec(MainObject objMain, short type, short time) { }

	private void createGiamPhongThu() { }

	private void createGiamTanCong() { }

	public short getTimeEff() { }

	public virtual void paint(mGraphics g) { }

	private void paintDien_Giat(mGraphics g) { }

	public void paintFrist(mGraphics g) { }

	public void SetXlech(int xlech) { }

	public virtual void update() { }

}

