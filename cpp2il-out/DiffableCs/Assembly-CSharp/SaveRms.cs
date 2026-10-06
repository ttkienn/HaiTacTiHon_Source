//Type is in global namespace

public class SaveRms
{
	public static string userLast; //Field offset: 0x0
	public const sbyte RMS_SER_SKILL = 0; //Field offset: 0x0
	public const sbyte RMS_SER_AUTO_MP_HP = 1; //Field offset: 0x0
	public const sbyte RMS_SER_AUTO_GET_ITEM = 2; //Field offset: 0x0
	public const sbyte RMS_SER_AUTO_MATERIAL = 3; //Field offset: 0x0
	public const sbyte RMS_SER_INDEX_HELP = 4; //Field offset: 0x0
	public const sbyte RMS_SER_AUTO_FIRE = 5; //Field offset: 0x0
	public const sbyte RMS_SER_UNIFORM = 6; //Field offset: 0x0
	public const sbyte RMS_SER_SKILL_BUFF = 7; //Field offset: 0x0
	public const sbyte RMS_SER_INDEX_LANG = 8; //Field offset: 0x0
	public const sbyte RMS_SER_SKILL_PLAYER = 9; //Field offset: 0x0
	public const sbyte RMS_SER_NHAN_VAT = 10; //Field offset: 0x0
	public static SByte[] datahotKeySkill; //Field offset: 0x8

	private static SaveRms() { }

	public SaveRms() { }

	public void loadAutoFire(SByte[] bData) { }

	public void loadAutoGetItem(SByte[] bData) { }

	public void loadAutoMaterial(SByte[] bData) { }

	public void loadAutoMp_Hp(SByte[] bData) { }

	public void loadBeginGame() { }

	public static DataInputStream loadData(string name) { }

	public void loadHotKey(SByte[] bData) { }

	public static string loadIpLast() { }

	public void loadUniform(SByte[] bData) { }

	public void loadUserLast() { }

	public bool loadUserPass() { }

	public static short loadVer(string name) { }

	public void SaveAutoFire() { }

	public void SaveAutoGetItem() { }

	public void SaveAutoMaterial() { }

	public void SaveAutoMp_Hp() { }

	public static void saveData(SByte[] dataSave, string name) { }

	public void saveDataeff(short id, SByte[] data) { }

	public void saveHotKey() { }

	public void SaveIndexHelp() { }

	public void saveIpLast(string ip) { }

	public void SaveShowNhanVat() { }

	public void SaveShowSkillBuff() { }

	public void SaveShowSkillPlayer() { }

	public void SaveUniform() { }

	public void saveUserLast(string user) { }

	public void saveUserPass(string user, string pass) { }

	public static void saveVer(short ver, string name) { }

	public void setLoadRMSServer(sbyte id, SByte[] data) { }

}

