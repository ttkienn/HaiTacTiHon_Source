//Type is in global namespace

public class Sudo_Screen : ChatTabScreen
{
	public const sbyte SUBCMD_SUDO_NHAN = 0; //Field offset: 0x0
	public static iCommand cmdClose; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_CANCEL_VITSI_SUDO = 20; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_VISIT_SUDO = 19; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_APPCEPT_VISIT_SUDO = 18; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_LEAVE = 17; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_CHAT_SUDO = 15; //Field offset: 0x0
	public const sbyte SUDO_INFO_PLAYER = 13; //Field offset: 0x0
	public const sbyte TYPE_INFO_ADD_REMOVE_MEMBER = 12; //Field offset: 0x0
	public const sbyte TYPE_INFO_REMOVE_CHAT = 11; //Field offset: 0x0
	public const sbyte CLIENT_TYPE_KICK = 16; //Field offset: 0x0
	public const sbyte TYPE_INFO_SUDO_CHAT = 9; //Field offset: 0x0
	public const sbyte TYPE_INFO_PLAYER_CHAT = 8; //Field offset: 0x0
	public const sbyte TYPE_INFO_PLAYER_SEND_INVITE = 7; //Field offset: 0x0
	public const sbyte SUBCMD_SUDO_IS_ACTIVE = 5; //Field offset: 0x0
	public const sbyte SUBCMD_SUDO_INVITE = 4; //Field offset: 0x0
	public const sbyte SUBCMD_SUDO_INFO = 3; //Field offset: 0x0
	public const sbyte SUBCMD_SUDO_LIST = 2; //Field offset: 0x0
	public const sbyte TYPE_INFO_LEAVE_CLAN = 10; //Field offset: 0x0
	public const sbyte SUBCMD_SUDO_HUY = 1; //Field offset: 0x0
	public static InfoMemList memCur; //Field offset: 0x8
	public static bool isNew; //Field offset: 0x10
	private int xbegintab; //Field offset: 0xD0
	public MainSudo clan; //Field offset: 0xD8
	public Sudo_Chat clanchat; //Field offset: 0xE0
	public Sudo_Mem member; //Field offset: 0xE8
	public Sudo_Info info; //Field offset: 0xF0
	public Clan_Cup achi; //Field offset: 0xF8
	private mVector vecCmd; //Field offset: 0x100

	public Sudo_Screen(MainSudo clan) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void getCurTab(int idSe) { }

	public static InfoMemList getMemInCLan(short Id) { }

	public static InfoMemList getMemInCLan(string name) { }

	public static void getRemoveMemInCLan(string name) { }

	public virtual void paint(mGraphics g) { }

	public void setAddCmd(iCommand cmd, sbyte pos) { }

	public void setCMDTabCur(iCommand cmd, sbyte pos) { }

	public void setData() { }

	public void setIsNewTab(ChatDetail tab) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

