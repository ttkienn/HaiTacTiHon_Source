//Type is in global namespace

public class RoomWantedScreen : MainScreen
{
	public static RoomWantedScreen instance; //Field offset: 0x0
	public string strShow; //Field offset: 0x50
	public mVector vecCmd; //Field offset: 0x58
	private InfoMemList infoPlayer; //Field offset: 0x60
	private int x; //Field offset: 0x68
	private int y; //Field offset: 0x6C
	private int w; //Field offset: 0x70
	private int h; //Field offset: 0x74
	private int wpos; //Field offset: 0x78
	private int idSelect; //Field offset: 0x7C
	private int type; //Field offset: 0x80
	private iCommand cmdClose; //Field offset: 0x88
	private iCommand cmdFind; //Field offset: 0x90
	private iCommand cmdCancle; //Field offset: 0x98
	private iCommand cmdActionChest; //Field offset: 0xA0
	private Int32[][] posChest; //Field offset: 0xA8

	public RoomWantedScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setAction(sbyte ac) { }

	public void setTimeCmdFind(int time) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

