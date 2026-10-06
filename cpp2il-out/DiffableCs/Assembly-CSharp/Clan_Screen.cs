//Type is in global namespace

public class Clan_Screen : ChatTabScreen
{
	public static iCommand cmdClose; //Field offset: 0x0
	public static InfoMemList memCur; //Field offset: 0x8
	public static bool isNew; //Field offset: 0x10
	private int xbegintab; //Field offset: 0xD0
	public MainClan clan; //Field offset: 0xD8
	public Clan_Chat clanchat; //Field offset: 0xE0
	public Clan_Mem member; //Field offset: 0xE8
	public Clan_Info info; //Field offset: 0xF0
	public Clan_Cup achi; //Field offset: 0xF8
	private mVector vecCmd; //Field offset: 0x100

	public Clan_Screen(MainClan clan) { }

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

