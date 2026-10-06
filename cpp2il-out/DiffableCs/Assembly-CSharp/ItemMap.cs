//Type is in global namespace

public class ItemMap : MainItemMap
{
	public static mImage imgGate; //Field offset: 0x0
	public const sbyte LIGHT_0 = 0; //Field offset: 0x0
	public const sbyte LIGHT_1 = 1; //Field offset: 0x0
	private FrameImage imgEff; //Field offset: 0x488
	public sbyte typeEff; //Field offset: 0x490
	public sbyte stepEff; //Field offset: 0x491

	public ItemMap(short IDItem, short IDImage, int dx, int dy, Int32[][] Block, sbyte layer) { }

	public MainImage getImage() { }

	public static void loadgate() { }

	public virtual void paint(mGraphics g) { }

	private void paintFrist(mGraphics g) { }

	private void paintLast(mGraphics g) { }

	public void setInfoItem(int x, int y) { }

}

