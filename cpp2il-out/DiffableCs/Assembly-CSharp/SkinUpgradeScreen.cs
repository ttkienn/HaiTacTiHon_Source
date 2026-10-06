//Type is in global namespace

public class SkinUpgradeScreen : ScreenUpgrade
{
	public static SkinUpgradeScreen instance; //Field offset: 0x0
	public static mVector vecSkin; //Field offset: 0x8
	public static mVector vecDa; //Field offset: 0x10
	public static SByte[] mTileCuongHoa; //Field offset: 0x18
	public ListNew listDa; //Field offset: 0x1D0
	private int yInven2; //Field offset: 0x1D8
	private int idSelect2; //Field offset: 0x1DC

	private static SkinUpgradeScreen() { }

	public SkinUpgradeScreen(sbyte typeRebuild, int size, mVector vecSkin1, mVector vecDa1) { }

	private bool checkNextStepFunc() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void continueUpgradeSkin() { }

	public virtual void getItemCurNew() { }

	public sbyte GetItemUpgrade(short Id, sbyte cat) { }

	public virtual mVector getMenuActionItem() { }

	private void getNameByIdItem(short id, sbyte type) { }

	private int getNumByIdItem(int id) { }

	private void loadImg() { }

	public virtual void paintBackGr(mGraphics g) { }

	public virtual void paintIconUpgrade(mGraphics g, int x, int y, MainItem item) { }

	public virtual void paintInven(mGraphics g) { }

	public virtual void paintTiLe(mGraphics g) { }

	public void setInfo_money(int valueMonney_1, short valueMonney_2, int valueMonney_3) { }

	public void setLvUpgradeItem(short idItem, sbyte level) { }

	public virtual void setPosInfo() { }

	public virtual void setStep() { }

	public void SetValueMayMan() { }

	public static void stopUpgradeSkin() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	public void updatePointerCheckBoxUpgradeSkin() { }

}

