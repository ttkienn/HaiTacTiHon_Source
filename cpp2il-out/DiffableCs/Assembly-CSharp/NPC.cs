//Type is in global namespace

public class NPC : MainObject
{
	public const sbyte NPC_THING = 0; //Field offset: 0x0
	public const sbyte NPC_PERSON = 1; //Field offset: 0x0
	public const sbyte NPC_PERSON_THING = 2; //Field offset: 0x0
	public const sbyte NPC_CLAN_DAO = 98; //Field offset: 0x0
	public const sbyte NPC_AREA = 99; //Field offset: 0x0
	public static Int32[][] hardCodeEventMoon; //Field offset: 0x0
	private sbyte typeNPC; //Field offset: 0x468
	private sbyte fMyRandom; //Field offset: 0x469
	private int numnextframe; //Field offset: 0x46C
	private int hardcodehead; //Field offset: 0x470
	private int hardcodexlechhead; //Field offset: 0x474
	private int indexEventMoon; //Field offset: 0x478
	public sbyte isPerson; //Field offset: 0x47C
	private int lastTick; //Field offset: 0x480
	private int framepaint; //Field offset: 0x484

	private static NPC() { }

	public NPC(string name, string namegt, short IDItem, short x, short y, sbyte wBlock, sbyte hBlock, sbyte typeNPC) { }

	public virtual iCommand getCenterCmd() { }

	public virtual void Giaotiep() { }

	public virtual int isNPC_Area() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintHead(mGraphics g, int x, int y, int trans) { }

	public virtual void paintName(mGraphics g, sbyte color, int isFocus) { }

	private void paintNpcEvent(mGraphics g) { }

	public void setDataFrame(sbyte IDImage, sbyte nFrame) { }

	public virtual void setFireObject(int value) { }

	public virtual void setPosEvent() { }

	public virtual void setTouchPoint() { }

	public virtual void update() { }

	public virtual void updateDySea() { }

}

