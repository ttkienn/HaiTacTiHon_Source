//Type is in global namespace

public class ListNew
{
	public int maxW; //Field offset: 0x10
	public int itemH; //Field offset: 0x14
	public int maxH; //Field offset: 0x18
	public int maxSize; //Field offset: 0x1C
	public int x; //Field offset: 0x20
	public int y; //Field offset: 0x24
	public int value; //Field offset: 0x28
	public int cmtoX; //Field offset: 0x2C
	public int cmx; //Field offset: 0x30
	public int cmdy; //Field offset: 0x34
	public int cmvy; //Field offset: 0x38
	public int cmxLim; //Field offset: 0x3C
	private int pointerDownTime; //Field offset: 0x40
	private int pointerDownFirstX; //Field offset: 0x44
	private Int32[] pointerDownLastX; //Field offset: 0x48
	public bool pointerIsDowning; //Field offset: 0x50
	public bool isDownWhenRunning; //Field offset: 0x51
	private int cmRun; //Field offset: 0x54
	private mVector vecCmd; //Field offset: 0x58
	public int w; //Field offset: 0x60
	private int cmvx; //Field offset: 0x64
	private int cmdx; //Field offset: 0x68

	public ListNew() { }

	public ListNew(int x, int y, int maxW, int maxH, int itemH, int maxSize, int limX, bool isLim0) { }

	public void moveCamera() { }

	public void setToX(int value) { }

	public void update_Pos_UP_DOWN() { }

	public void updateMenu() { }

	public void updateMenuKey() { }

	public void updatePos_LEFT_RIGHT() { }

}

