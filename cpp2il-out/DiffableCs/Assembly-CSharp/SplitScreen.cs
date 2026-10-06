//Type is in global namespace

public class SplitScreen : ScreenUpgrade
{
	public static SplitScreen instance; //Field offset: 0x0
	public const sbyte RE_CUONG_HOA_SKIN = 22; //Field offset: 0x0
	public const sbyte RE_HANH_TRINH = 21; //Field offset: 0x0
	public const sbyte RE_GHEP_NHIEU_NGLIEU_THANH_1 = 20; //Field offset: 0x0
	public const sbyte RE_DUC_LO_DIAL = 19; //Field offset: 0x0
	public const sbyte RE_CUONG_HOA_DIAL = 18; //Field offset: 0x0
	public const sbyte RE_SIEU_NANGCAPITEM = 15; //Field offset: 0x0
	public const sbyte RE_DO_9X = 14; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_CAP = 13; //Field offset: 0x0
	public const sbyte RE_CONG_CHE_TAC = 12; //Field offset: 0x0
	public const sbyte RE_KICH_AN = 11; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL = 9; //Field offset: 0x0
	public const sbyte RE_DEVIL_CHEST = 8; //Field offset: 0x0
	public const sbyte RE_HOAN_MY = 10; //Field offset: 0x0
	public const sbyte RE_TRADE = 6; //Field offset: 0x0
	public const sbyte RE_NANGCAPITEM = 5; //Field offset: 0x0
	public const sbyte RE_NANGCAPDA = 4; //Field offset: 0x0
	public const sbyte RE_LAY = 3; //Field offset: 0x0
	public const sbyte RE_DUT = 2; //Field offset: 0x0
	public const sbyte RE_KHAM = 1; //Field offset: 0x0
	public const sbyte RE_SPLIT = 0; //Field offset: 0x0
	public const sbyte RE_CHUYEN_HOA = 7; //Field offset: 0x0
	public short idItem9x; //Field offset: 0x1D0
	public MainItem potionBua; //Field offset: 0x1D8
	private bool isPaintrectPlus; //Field offset: 0x1E0
	private InputDialog input; //Field offset: 0x1E8
	public int PriceChuyenHoa; //Field offset: 0x1F0
	public sbyte tile; //Field offset: 0x1F4
	public mVector vecDaKhamHanhTrinh; //Field offset: 0x1F8
	public short idMinimap; //Field offset: 0x200
	public string nameMinimap; //Field offset: 0x208

	public SplitScreen(sbyte typeRebuild, int size) { }

	public void ChangeCmd() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual iCommand getCmdShopMore() { }

	private void getMenu() { }

	public virtual mVector getMenuActionItem() { }

	public virtual bool isGetItemUpgrade(short Id, sbyte cat) { }

	public virtual void paintIconUpgrade(mGraphics g, int x, int y, MainItem item) { }

	public virtual void paintRectPlus(mGraphics g) { }

	public virtual void paintTiLe(mGraphics g) { }

	private void sendUpgradeDa(int t) { }

	public void setSetItem() { }

	public virtual void setStart(sbyte typeRebuild, int size) { }

	public virtual void setStep() { }

	private void updateCONG_CHE_TAC() { }

	private void updateLAY() { }

	public virtual void updateNewUpgrade() { }

	private void updateSplit() { }

	public void XoaDa(short id) { }

}

