//Type is in global namespace

public class MsgDialog : MainDialog
{
	public const sbyte CMD_CLOSE = -1; //Field offset: 0x0
	public const sbyte INFO_CLAN = 10; //Field offset: 0x0
	public const sbyte RE_CONNECT = 9; //Field offset: 0x0
	public const sbyte WAITING_CONNECT = 8; //Field offset: 0x0
	public const sbyte NORMAL_ITEM = 7; //Field offset: 0x0
	public const sbyte TIME = 6; //Field offset: 0x0
	public const sbyte NORMAL_2 = 5; //Field offset: 0x0
	public const sbyte SKILL_INFO = 4; //Field offset: 0x0
	public const sbyte QUEST = 2; //Field offset: 0x0
	public const sbyte WAITING = 1; //Field offset: 0x0
	public const sbyte NORMAL = 0; //Field offset: 0x0
	public const sbyte CMD_CONFIRM_DOI_QUA = 16; //Field offset: 0x0
	public const sbyte CMD_CLOSE_MSG_SPAM = 15; //Field offset: 0x0
	public const sbyte CMD_REWARD = 13; //Field offset: 0x0
	public const sbyte CMD_DAILY_LOGIN = 14; //Field offset: 0x0
	public const sbyte CMD_OPEN_NEXT = 11; //Field offset: 0x0
	public const sbyte CMD_CLOSE_GIFT = 10; //Field offset: 0x0
	public const sbyte CMD_OK_AUTO_FIRE = 9; //Field offset: 0x0
	public const sbyte CMD_JOIN_ITEM_OK = 8; //Field offset: 0x0
	public const sbyte CMD_JOIN_ITEM = 7; //Field offset: 0x0
	public const sbyte CMD_OK_AUTO_GET_ITEM = 6; //Field offset: 0x0
	public const sbyte CMD_LEARN_SKILL = 5; //Field offset: 0x0
	public const sbyte CMD_OK_AUTO_MP_HP = 4; //Field offset: 0x0
	public const sbyte CMD_CHANGE_EQUIP = 3; //Field offset: 0x0
	public const sbyte CMD_CLOSE_QUEST = 2; //Field offset: 0x0
	public const sbyte CMD_CANCEL_QUEST = 1; //Field offset: 0x0
	public const sbyte CMD_DOWNLOAD = 0; //Field offset: 0x0
	public const sbyte CMD_CLOSE_SOUND = 12; //Field offset: 0x0
	public static mVector vecEff; //Field offset: 0x0
	public static FrameImage fraImgWaiting; //Field offset: 0x8
	public static FrameImage fraAutoMpHp; //Field offset: 0x10
	public static int hPlus; //Field offset: 0x18
	public static int xEFF; //Field offset: 0x1C
	public static int yEFF; //Field offset: 0x20
	public static bool isAuroReconect; //Field offset: 0x24
	public int idCommand; //Field offset: 0x70
	public mVector cmdList; //Field offset: 0x78
	public mVector vecEffUni; //Field offset: 0x80
	public iCommand cmdClose; //Field offset: 0x88
	public iCommand cmdChangeEquip; //Field offset: 0x90
	public mFont fontDia; //Field offset: 0x98
	public int fWait; //Field offset: 0xA0
	public int wItem; //Field offset: 0xA4
	public int idSelect; //Field offset: 0xA8
	public MainQuest quest; //Field offset: 0xB0
	public bool isClose; //Field offset: 0xB8
	public bool isNewShop; //Field offset: 0xB9
	public ListNew list; //Field offset: 0xC0
	public string nameDialog; //Field offset: 0xC8
	public string infoHelp; //Field offset: 0xD0
	public int wInfoHelp; //Field offset: 0xD8
	public int tickCloseInfoHelp; //Field offset: 0xDC
	private CountDownTicket timeDialog; //Field offset: 0xE0
	public mVector vecItem; //Field offset: 0xE8
	private MainClan clanpaint; //Field offset: 0xF0
	private string linkDownLoad; //Field offset: 0xF8
	public int wShowPaper; //Field offset: 0x100
	public int maxWShow; //Field offset: 0x104
	public int vShow; //Field offset: 0x108
	private Skill_Info skill; //Field offset: 0x110
	private Int32[] posValueName; //Field offset: 0x118
	public int xBegin; //Field offset: 0x120
	public int w2cmd; //Field offset: 0x124
	public int miniItem; //Field offset: 0x128
	private int lastTick; //Field offset: 0x12C
	private int framepaint; //Field offset: 0x130

	private static MsgDialog() { }

	public MsgDialog() { }

	public static void addEff(MainEffect eff) { }

	public void beginDia() { }

	public void closeDialog() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void paintInfoHelp(mGraphics g) { }

	public void setinfo(string info, mVector vecCmd, bool isCmdClose, sbyte type) { }

	public void setinfoClan(MainClan Clan) { }

	public void setinfoDownload(string info, string link) { }

	public void setInfoHelp(string str) { }

	public void setinfoItem(string info, mVector vecitem, mVector vecCmd, bool isCmdClose) { }

	public void setinfoNew(string info, mVector vecCmd, bool isCmdClose, string nameDia) { }

	public void setinfoParty(mVector att) { }

	public void setinfoQuest(MainQuest quest, bool isNew) { }

	public void setinfoSkillInfo(Skill_Info skill) { }

	public void setNhanTraQuest(MainQuest quest, iCommand cmd) { }

	public void setPosCmdNew(int yplus, bool isLast) { }

	public void setWaitinginfo(string info, mVector vecCmd, bool isCmdClose, sbyte type, int time) { }

	public virtual void update() { }

	public void updateClose() { }

	public void updateInfoHelp() { }

	public virtual void updatekey() { }

	public override void updatekeyCMD() { }

	public void updateOpen() { }

	public virtual void updatePointer() { }

}

