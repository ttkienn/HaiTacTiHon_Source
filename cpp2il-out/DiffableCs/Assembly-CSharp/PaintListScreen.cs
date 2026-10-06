//Type is in global namespace

public class PaintListScreen : SubScreen
{
	public const sbyte DUNGONE_LIST = -4; //Field offset: 0x0
	public const sbyte LIST_MEM_TOP_PHAO = 16; //Field offset: 0x0
	public const sbyte LIST_MEM_FIGHT_CLAN = 15; //Field offset: 0x0
	public const sbyte TOP_CLAN_THANH_TICH = 14; //Field offset: 0x0
	public const sbyte TOP_CLAN_TRUY_NA = 13; //Field offset: 0x0
	public const sbyte TOP_CLAN_PVP = 12; //Field offset: 0x0
	public const sbyte TOP_CLAN_LEVEL_PLAYER = 11; //Field offset: 0x0
	public const sbyte PLAYER_LIST_WANTED = 9; //Field offset: 0x0
	public const sbyte LIST_MEM_FIGHT_SUPER_BOSS = 17; //Field offset: 0x0
	public const sbyte PLAYER_LIST_PVP = 7; //Field offset: 0x0
	public const sbyte MEM_CLAN_LIST = 5; //Field offset: 0x0
	public const sbyte PLAYER_LIST_LV = 4; //Field offset: 0x0
	public const sbyte ID_GET_PAGE = 3; //Field offset: 0x0
	public const sbyte BLACK_LIST = 2; //Field offset: 0x0
	public const sbyte PARTY_LIST = -1; //Field offset: 0x0
	public const sbyte FRIEND_LIST = -2; //Field offset: 0x0
	public const sbyte EVENT_LIST = -3; //Field offset: 0x0
	public const sbyte CLAN_LIST = 6; //Field offset: 0x0
	public string textrong; //Field offset: 0x70
	public int hContent; //Field offset: 0x78
	public mVector vecMenu; //Field offset: 0x80
	public ListNew list; //Field offset: 0x88
	public InfoMemList memCur; //Field offset: 0x90
	public int timeShowFocus; //Field offset: 0x98
	public int miniItem; //Field offset: 0x9C
	public int idSelect; //Field offset: 0xA0
	public int idCommand; //Field offset: 0xA4
	public mVector vecPlayer; //Field offset: 0xA8
	public string nameList; //Field offset: 0xB0
	public iCommand cmdMenu; //Field offset: 0xB8
	public iCommand cmdClose; //Field offset: 0xC0
	public iCommand cmdInfoPlayer; //Field offset: 0xC8
	public iCommand cmdChat; //Field offset: 0xD0
	public iCommand cmdAddFriend; //Field offset: 0xD8
	public iCommand cmdMove; //Field offset: 0xE0
	public iCommand cmdMenuTouchPlayer; //Field offset: 0xE8
	public int hBegin; //Field offset: 0xF0
	public bool isLoad; //Field offset: 0xF4
	public bool isDelEvent; //Field offset: 0xF5
	public int yPaintFirst; //Field offset: 0xF8

	public PaintListScreen(sbyte type, mVector vec, string name, int maxWSub, int H) { }

	public override void beginShow() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public override void delMem(InfoMemList mem) { }

	public override void doMenu() { }

	public override void doMenuTouchPlayer() { }

	public virtual bool keyBack() { }

	public virtual void paint(mGraphics g) { }

	public override void paintBg(mGraphics g) { }

	public override void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public override void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public override void setCamera() { }

	public void setClip(mGraphics g) { }

	public virtual void Show(MainScreen screen) { }

	public virtual void update() { }

	public void updateInfo() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

