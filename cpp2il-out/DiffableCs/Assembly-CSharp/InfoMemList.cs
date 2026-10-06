//Type is in global namespace

public class InfoMemList
{
	public const sbyte ADD_FRIEND = 0; //Field offset: 0x0
	public const sbyte ADD_PARTY = 1; //Field offset: 0x0
	public const sbyte ADD_CHAT = 2; //Field offset: 0x0
	public const sbyte ADD_FIGHT = 3; //Field offset: 0x0
	public const sbyte ADD_TRADE = 4; //Field offset: 0x0
	public const sbyte ADD_XIN_VAO_PARTY = 5; //Field offset: 0x0
	public const sbyte ADD_MOI_VAO_CLAN = 6; //Field offset: 0x0
	public const sbyte ADD_CLAN_FIGHT = 7; //Field offset: 0x0
	public const sbyte ADD_BAISU = 8; //Field offset: 0x0
	public const sbyte CAPTION_TRUONG = 0; //Field offset: 0x0
	public const sbyte CAPTION_PHO = 1; //Field offset: 0x0
	public const sbyte CAPTION_HOATIEU = 2; //Field offset: 0x0
	public const sbyte CAPTION_MEM = 10; //Field offset: 0x0
	public const sbyte CAPTION_SUPHU = 1; //Field offset: 0x0
	public const sbyte CAPTION_DETU = 2; //Field offset: 0x0
	private int x; //Field offset: 0x10
	private int y; //Field offset: 0x14
	public short idmap; //Field offset: 0x18
	public short idArea; //Field offset: 0x1A
	public string name; //Field offset: 0x20
	public string info; //Field offset: 0x28
	public string infoFull; //Field offset: 0x30
	public string title; //Field offset: 0x38
	public string expSudo; //Field offset: 0x40
	public bool isTransInfor; //Field offset: 0x48
	public bool isTransName; //Field offset: 0x49
	public bool isPlusInfo; //Field offset: 0x4A
	public bool isPlusName; //Field offset: 0x4B
	public int cmxInfo; //Field offset: 0x4C
	public int cmxLimInfo; //Field offset: 0x50
	public int cmxName; //Field offset: 0x54
	public int cmxLimName; //Field offset: 0x58
	public int id; //Field offset: 0x5C
	public int idEvent; //Field offset: 0x60
	public int hp; //Field offset: 0x64
	public int maxhp; //Field offset: 0x68
	public int Lv; //Field offset: 0x6C
	public int priceFight; //Field offset: 0x70
	public int numTangqua; //Field offset: 0x74
	public int numQuest; //Field offset: 0x78
	public int rank; //Field offset: 0x7C
	public sbyte isMain; //Field offset: 0x80
	public sbyte typeOnline; //Field offset: 0x81
	public sbyte typeEvent; //Field offset: 0x82
	public sbyte indexIconEvent; //Field offset: 0x83
	public sbyte chucInClan; //Field offset: 0x84
	public sbyte typeFight; //Field offset: 0x85
	public sbyte chucInSudo; //Field offset: 0x86
	public short lvSudo; //Field offset: 0x88
	public short head; //Field offset: 0x8A
	public short hair; //Field offset: 0x8C
	public short hat; //Field offset: 0x8E
	public short body; //Field offset: 0x90
	public short leg; //Field offset: 0x92
	public short weapon; //Field offset: 0x94
	public bool isNew; //Field offset: 0x96
	public bool isMe; //Field offset: 0x97
	public int gopRuby; //Field offset: 0x98
	public int congHien; //Field offset: 0x9C
	public MainObject charShow; //Field offset: 0xA0
	public string namePlayerNhan; //Field offset: 0xA8
	public sbyte isWantedSuccess; //Field offset: 0xB0
	public sbyte isReceiveGift; //Field offset: 0xB1
	public sbyte isOwn; //Field offset: 0xB2
	public QuaNapThe quaNapThe; //Field offset: 0xB8
	public ItemQuaNT item; //Field offset: 0xC0

	public InfoMemList(int id) { }

	private static bool checkReturnEvent(sbyte type, string name) { }

	public string getCaptionClan(sbyte type) { }

	public string getCaptionSudo(sbyte type) { }

	public static InfoMemList getEvent(string name, sbyte type) { }

	public static InfoMemList getMem(int id, mVector vec) { }

	public void setAction() { }

	public static void setTypeEvent(int ID, sbyte typeEvent, string name, string info, int priceFight, int typeFight) { }

	public void updateChar(short head, short hair, short hat, short body, short leg, short weapon) { }

	public void updateCharFace(short head, short hair, short hat) { }

	public void updateCharFullPart(short head, short hair, short hat, short body, short leg, short weapon) { }

	public void updateData(string name, short idMap, sbyte isMain, sbyte idArea) { }

	public void updateFace(short head, short hair, short hat) { }

	public void updateHP(int hp, int maxhp, int Lv) { }

	public void updateMemClan(string name, short Lv, sbyte levelInClan, short numDonate, short numGopRuby, short numQuest, int numCongHien) { }

	public void updateXY(int x, int y) { }

}

