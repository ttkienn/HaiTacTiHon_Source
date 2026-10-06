//Type is in global namespace

public class ChatDetail : AvMain
{
	public const sbyte TYPE_SERVER = 1; //Field offset: 0x0
	public const sbyte TYPE_ADDFRIEND = 2; //Field offset: 0x0
	public const sbyte TYPE_CLAN_CHAT = 3; //Field offset: 0x0
	public const sbyte TYPE_CLAN_MEM = 4; //Field offset: 0x0
	public const sbyte TYPE_CLAN_INFO = 5; //Field offset: 0x0
	public const sbyte TYPE_TROCHUYEN = 0; //Field offset: 0x0
	public const sbyte TYPE_BANGHOI_NHOM = 1; //Field offset: 0x0
	public const sbyte BG_BLUE_DARK = 0; //Field offset: 0x0
	public const sbyte BG_BLUE = 1; //Field offset: 0x0
	public const sbyte BG_RED = 2; //Field offset: 0x0
	public const sbyte BG_ORANGE = 3; //Field offset: 0x0
	public const sbyte BG_BROWN = 4; //Field offset: 0x0
	public const sbyte BG_GREEN = 5; //Field offset: 0x0
	public const sbyte BG_GOLD = 6; //Field offset: 0x0
	public const sbyte BG_SILVER = 7; //Field offset: 0x0
	public const sbyte BG_COPPER = 8; //Field offset: 0x0
	public const sbyte BG_WHITE = 9; //Field offset: 0x0
	public const sbyte TYPE_CHAT = 0; //Field offset: 0x0
	public const sbyte BG_FOCUS = 10; //Field offset: 0x0
	public int x; //Field offset: 0x40
	public int y; //Field offset: 0x44
	public int miniItem; //Field offset: 0x48
	public int xBe; //Field offset: 0x4C
	public int yBe; //Field offset: 0x50
	public int wCon; //Field offset: 0x54
	public int hCon; //Field offset: 0x58
	public int wItem; //Field offset: 0x5C
	public int hChat; //Field offset: 0x60
	public int idSelect; //Field offset: 0x64
	public ListNew CamDetailChat; //Field offset: 0x68
	public mVector vecDetail; //Field offset: 0x70
	public string name; //Field offset: 0x78
	public string friend; //Field offset: 0x80
	public string shortName; //Field offset: 0x88
	public string shortNameFocus; //Field offset: 0x90
	public sbyte timeNew; //Field offset: 0x98
	public bool isNew; //Field offset: 0x99
	public TField tfchat; //Field offset: 0xA0
	public sbyte typeChat; //Field offset: 0xA8
	public int limY; //Field offset: 0xAC
	private int indexColor; //Field offset: 0xB0
	private sbyte typeColorChat; //Field offset: 0xB4
	public Scroll scrChat; //Field offset: 0xB8

	public ChatDetail(string name, sbyte type) { }

	public MainTextChat[] addChatNew(String[] mstr, sbyte color) { }

	public void addStartChat(string nametext) { }

	public void addString(string str, string nametext, int color) { }

	public override void addStringClan(short ID, string str, string nametext, string textRight, sbyte typeBg, sbyte IDEvent, short IdMem, long time) { }

	public override void beginFocus() { }

	private sbyte colorServer() { }

	public int getColorBg(sbyte typecolor) { }

	public int getColorBorderBg(sbyte typecolor) { }

	public int getColorBorderNumber(sbyte typecolor) { }

	public virtual void paint(mGraphics g) { }

	public void paintBorder(mGraphics g, sbyte typeColorBg, sbyte typeChatLeftRight, int wLech, int hpaint, int ypaint, bool isfocus) { }

	public void sendChat() { }

	private sbyte setColorText(string name) { }

	public override void setIsNew(bool isnew) { }

	public void setLim() { }

	public override void setPos(int xBe, int yBe, int wCon, int hCon, int miniItem, int hchat) { }

	public virtual void update() { }

	public override void updateCameraNew(int size, sbyte type) { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

