//Type is in global namespace

public class Effect_UpLv_Item
{
	private int wnew; //Field offset: 0x10
	private Int32[][] colorBorder; //Field offset: 0x18
	private Int32[] size; //Field offset: 0x20
	private Int32[] size15; //Field offset: 0x28
	private int valueTest; //Field offset: 0x30
	private int lv; //Field offset: 0x34

	public Effect_UpLv_Item() { }

	public int getValueUpgrade(int up) { }

	public void paintUpgradeEffect(int x, int y, int upgrade, int w, mGraphics g, int lech, bool isBorder) { }

	public int upgradeEffectX(int tick, int w) { }

	public int upgradeEffectX2(int tick, int w) { }

	public int upgradeEffectY(int tick, int w) { }

}

