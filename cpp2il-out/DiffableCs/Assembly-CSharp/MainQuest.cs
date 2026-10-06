//Type is in global namespace

public class MainQuest : AvMain
{
	public const int MAIN = 0; //Field offset: 0x0
	public const int SUB = 1; //Field offset: 0x0
	public const int REPLAY = 2; //Field offset: 0x0
	public const int CLAN = 3; //Field offset: 0x0
	public const int TYPE_ITEM = 0; //Field offset: 0x0
	public const int TYPE_MONSTER = 1; //Field offset: 0x0
	public const int NHAN = 0; //Field offset: 0x0
	public const int TRA = 1; //Field offset: 0x0
	public const sbyte STATUSQUEST_ADD = 0; //Field offset: 0x0
	public const sbyte STATUSQUEST_CURRENT = 1; //Field offset: 0x0
	public const sbyte STATUSQUEST_FINISH = 2; //Field offset: 0x0
	public const sbyte ACTION_QUEST_TALK = 0; //Field offset: 0x0
	public const sbyte ACTION_QUEST_KILL_MON = 1; //Field offset: 0x0
	public const sbyte ACTION_QUEST_GET_ITEM = 2; //Field offset: 0x0
	public sbyte typeMainSub; //Field offset: 0x40
	public sbyte statusQuest; //Field offset: 0x41
	public sbyte typeActionQuest; //Field offset: 0x42
	public int idNPC; //Field offset: 0x44
	public int idNPC_Sub; //Field offset: 0x48
	public short ID; //Field offset: 0x4C
	public short idMapHelp; //Field offset: 0x4E
	public short lvRequest; //Field offset: 0x50
	public string name; //Field offset: 0x58
	public string strTalk; //Field offset: 0x60
	public string strNhacNho; //Field offset: 0x68
	public String[] mstrTalk; //Field offset: 0x70
	public string strShowDialog; //Field offset: 0x78
	public string strNPC_Map; //Field offset: 0x80
	public mVector vecTypeQuest; //Field offset: 0x88
	private int step; //Field offset: 0x90

	public MainQuest(short ID) { }

	public void beginQuest(short IDObj) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public iCommand getCmeTabQuest() { }

	public string getMainSub() { }

	public static MainQuest getQuest(short ID) { }

	public static void LoadNamePotionQuest(DataInputStream iss, bool isSave) { }

	public void nextStep() { }

	public iCommand setCmd() { }

	public iCommand setCmdDialog() { }

	public static void updateDataQuestGetPotion(short id) { }

	public static void updateDataQuestKillMon(short idMonster) { }

}

