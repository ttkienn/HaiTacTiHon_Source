//Type is in global namespace

public class GamePad
{
	private int xC; //Field offset: 0x10
	private int yC; //Field offset: 0x14
	private int xM; //Field offset: 0x18
	private int yM; //Field offset: 0x1C
	private int xMLast; //Field offset: 0x20
	private int yMLast; //Field offset: 0x24
	private int R; //Field offset: 0x28
	private int r; //Field offset: 0x2C
	private int d; //Field offset: 0x30
	private int xTemp; //Field offset: 0x34
	private int yTemp; //Field offset: 0x38
	private int deltaX; //Field offset: 0x3C
	private int deltaY; //Field offset: 0x40
	private int delta; //Field offset: 0x44
	private int angle; //Field offset: 0x48
	public int xZone; //Field offset: 0x4C
	public int yZone; //Field offset: 0x50
	public int wZone; //Field offset: 0x54
	public int hZone; //Field offset: 0x58
	private bool isGamePad; //Field offset: 0x5C
	public bool isSmallGamePad; //Field offset: 0x5D
	public bool isMediumGamePad; //Field offset: 0x5E
	public bool isLargeGamePad; //Field offset: 0x5F

	public GamePad() { }

	private bool checkPointerMove(int distance) { }

	public bool disableCheckDrag() { }

	public bool disableClickMove() { }

	public void paint(mGraphics g) { }

	private void resetHold() { }

	public void update() { }

}

