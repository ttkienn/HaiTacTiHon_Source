//Type is in global namespace

public class MapGotoSky
{
	public static int x; //Field offset: 0x0
	public static int y; //Field offset: 0x4
	public static int w; //Field offset: 0x8
	public static int h; //Field offset: 0xC
	public static int stepMove; //Field offset: 0x10
	public static int hMax; //Field offset: 0x14
	public static int wMax; //Field offset: 0x18
	public static mVector vecEff_Song_Ria; //Field offset: 0x20
	public static mVector vecEff_Song_Giua; //Field offset: 0x28
	public static mVector vecEff_Song_Nho; //Field offset: 0x30
	public static mVector vecEff_Song_Keo; //Field offset: 0x38
	public static mVector vecEff_Song_Bien; //Field offset: 0x40
	public static mVector vecEff_Song_Bien_Nho; //Field offset: 0x48
	public static mVector vecEff_May; //Field offset: 0x50
	public static mVector vecEff_Die; //Field offset: 0x58
	public static mVector vecEff_May_Goto; //Field offset: 0x60
	public static FrameImage fraEffSky0; //Field offset: 0x68
	public static FrameImage fraEffSky1; //Field offset: 0x70
	public static FrameImage fraEffSky2; //Field offset: 0x78
	public static FrameImage fraEffSky3; //Field offset: 0x80
	public static FrameImage fraEffSky4; //Field offset: 0x88
	public static FrameImage fraEffSky5; //Field offset: 0x90
	public static FrameImage fraEffSky6; //Field offset: 0x98
	public static FrameImage fraEffSky7; //Field offset: 0xA0
	public static mImage[] mcloud; //Field offset: 0xA8
	public static mImage[] mcloudGoto; //Field offset: 0xB0
	public static Int32[] mPlayFrameSong; //Field offset: 0xB8
	public static Int32[] mPlayFrameBottom; //Field offset: 0xC0
	public static Int32[][] mPosGotoSky; //Field offset: 0xC8
	public static Int32[][] mGo; //Field offset: 0xD0
	public static Int32[][] mPosWinSky; //Field offset: 0xD8
	public static bool isBeginEffBoat; //Field offset: 0xE0
	public static bool isStopUpdateCamera; //Field offset: 0xE1
	public static int tickGo; //Field offset: 0xE4
	public static int valueGo; //Field offset: 0xE8

	private static MapGotoSky() { }

	public MapGotoSky() { }

	public static void LoadImage() { }

	public static void paint(mGraphics g) { }

	public static void paintAudition(mGraphics g) { }

	public static void paintEff(mGraphics g) { }

	public static void setPos() { }

	public static void SetPosNextMove() { }

	public static void setTypeMoveredLine(sbyte type) { }

	public static void update() { }

	public static void updateActionPlayer() { }

	public static void updateEff() { }

	private static void updateKeyAudition() { }

}

