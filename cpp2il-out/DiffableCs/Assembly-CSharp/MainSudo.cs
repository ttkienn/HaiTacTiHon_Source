//Type is in global namespace

public class MainSudo
{
	public string name; //Field offset: 0x10
	public string nameCaption; //Field offset: 0x18
	public string strVoice; //Field offset: 0x20
	public string diemSudo; //Field offset: 0x28
	public int level; //Field offset: 0x30
	public int numMem; //Field offset: 0x34
	public int maxNumMem; //Field offset: 0x38
	public int xp; //Field offset: 0x3C
	public int maxXp; //Field offset: 0x40
	public int rank; //Field offset: 0x44
	public int chucvu; //Field offset: 0x48
	public int pointAttri; //Field offset: 0x4C
	public int maxAttri; //Field offset: 0x50
	public int rubiClan; //Field offset: 0x54
	public int beryClan; //Field offset: 0x58
	public int countAction; //Field offset: 0x5C
	public short ID; //Field offset: 0x60
	public short idIcon; //Field offset: 0x62
	public sbyte isLevelUp; //Field offset: 0x64
	public sbyte trungsinh; //Field offset: 0x65
	public sbyte borderIconClan; //Field offset: 0x66
	public mVector vecMem; //Field offset: 0x68
	public mVector vecChatCLan; //Field offset: 0x70
	public mVector vecAchi; //Field offset: 0x78
	public Int16[] numAttribute; //Field offset: 0x80

	public MainSudo() { }

	public MainSudo(short ID, sbyte levelInClan) { }

	public MainSudo(short ID, string name) { }

	public static bool isPhongChuc() { }

	public void setAttri(Int16[] mAttri) { }

	public void setData(short idIcon, string nameCaption, short level, int xp, int maxXP, sbyte numMem, sbyte maxNumMem, int rank, string strVoice) { }

	public void updateListMem(mVector vec) { }

	public static void UpdateRankMe(sbyte level) { }

}

