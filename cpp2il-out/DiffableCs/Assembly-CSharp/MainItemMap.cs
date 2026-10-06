//Type is in global namespace

public class MainItemMap : MainObject
{
	public const sbyte ITEM_MAP = 0; //Field offset: 0x0
	public const sbyte EFF_MAP = 1; //Field offset: 0x0
	public const sbyte BOAT_MAP = 1; //Field offset: 0x0
	public sbyte TypeItem; //Field offset: 0x468
	public sbyte layer; //Field offset: 0x469
	public short IDItem; //Field offset: 0x46A
	public short IDImage; //Field offset: 0x46C
	public Int32[][] Block; //Field offset: 0x470
	public mImage img; //Field offset: 0x478
	public bool isLoadDataOk; //Field offset: 0x480

	public MainItemMap() { }

	public MainItemMap(short ID) { }

	public MainItemMap(short IDItem, short IDImage, int dx, int dy, Int32[][] Block, sbyte layer) { }

	public override bool isInScreen() { }

	public virtual void paint(mGraphics g) { }

	public virtual void update() { }

}

