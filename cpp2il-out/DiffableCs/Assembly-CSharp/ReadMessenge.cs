//Type is in global namespace

public class ReadMessenge : AvMain
{
	public static iCommand cmdOffInterface; //Field offset: 0x0
	public const sbyte CAPCHAR_RED_LINE_FINISH = 2; //Field offset: 0x0
	public const sbyte CAPCHAR_RED_LINE_FAIL = 1; //Field offset: 0x0
	public const sbyte CAPCHAR_RED_LINE = 0; //Field offset: 0x0
	public const sbyte CHECK_ONE_MEM_CANCLE = 3; //Field offset: 0x0
	public const sbyte CHECK_MEM_CANCLE = 2; //Field offset: 0x0
	public const sbyte CHECK_MEM_READY = 1; //Field offset: 0x0
	public const sbyte CAPCHAR_GOTO_SKY = 3; //Field offset: 0x0
	public const sbyte CHECK_LIST_PHO_BANG = 0; //Field offset: 0x0
	public const sbyte RE_GHEP_NHIEU_NGLIEU_THANH_1_OK = 21; //Field offset: 0x0
	public const sbyte RE_GHEP_NHIEU_NGLIEU_THANH_1_OPEN = 20; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_TI_LE = 19; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_TI_LE = 18; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_OK_KHAM = 17; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_ERROR = 16; //Field offset: 0x0
	public const sbyte AU_REVICE = 1; //Field offset: 0x0
	public const sbyte CAPCHAR_GOTO_SKY_FAIL = 4; //Field offset: 0x0
	public const sbyte CAPCHAR_GOTO_SKY_FINISH = 5; //Field offset: 0x0
	public const sbyte TIME_PVP_PHO_BANG = 0; //Field offset: 0x0
	public const sbyte CLAN_REMOVE_CHAT = 11; //Field offset: 0x0
	public const sbyte CLAN_ALL_CHAT_IN_CLAN = 9; //Field offset: 0x0
	public const sbyte CLAN_MOI_VAO_CLAN = 7; //Field offset: 0x0
	public const sbyte CLAN_CHAT_IN_CLAN = 8; //Field offset: 0x0
	public const sbyte CLAN_INFO_PLAYER = 5; //Field offset: 0x0
	public const sbyte CLAN_ATTRIBUTE = 4; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_LIST_MEM = 3; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_DATA = 2; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_CHUC_VU = 1; //Field offset: 0x0
	public const sbyte CLAN_CREATE_DATA = 0; //Field offset: 0x0
	public const sbyte TIME_SCORE_NEW = 5; //Field offset: 0x0
	public const sbyte TIME_SCORE = 4; //Field offset: 0x0
	public const sbyte TIME_PHO_BANG_LITTLE_REVICE = 3; //Field offset: 0x0
	public const sbyte TIME_PHO_BANG_LITTLE = 2; //Field offset: 0x0
	public const sbyte TIME_HP_PHO_BANG = 1; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_REMOVE = 15; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_SET = 14; //Field offset: 0x0
	public const sbyte RE_DEVIL_ITEM_OPEN = 13; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_OK_KHAM = 12; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_DUC_LO = 7; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_TACH_DA = 6; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_UPGRADE_DA = 5; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_KHAM = 4; //Field offset: 0x0
	public const sbyte RE_ITEM_ERROR = 3; //Field offset: 0x0
	public const sbyte RE_ITEM_REMOVE = 2; //Field offset: 0x0
	public const sbyte RE_ITEM_SET = 1; //Field offset: 0x0
	public const sbyte RE_ITEM_OPEN = 0; //Field offset: 0x0
	public const sbyte TICKET_X2XP = 3; //Field offset: 0x0
	public const sbyte TICKET_PVP = 2; //Field offset: 0x0
	public const sbyte TICKET_BOSS = 1; //Field offset: 0x0
	public const sbyte TICKET_BANHMI = 0; //Field offset: 0x0
	public const sbyte TYPE_SEND_INFO = 1; //Field offset: 0x0
	public const sbyte TRADE_ACTION_SET = 1; //Field offset: 0x0
	public const sbyte TRADE_ACTION_DEL = 0; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_HOAN_MY = 20; //Field offset: 0x0
	public const sbyte CLAN_LEAVE_CLAN = 10; //Field offset: 0x0
	public const sbyte RE_ITEM_FAIL_HOAN_MY = 21; //Field offset: 0x0
	public const sbyte RE_ITEM_FAIL_KICH_AN = 23; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_ERROR = 11; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_REMOVE = 10; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_SET = 9; //Field offset: 0x0
	public const sbyte RE_DEVIL_SKILL_OPEN = 8; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_DUC_BANG_BUA_VIP = 34; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_DUC_BANG_BUA_THUONG = 33; //Field offset: 0x0
	public const sbyte RE_GHEP_DO_FAIL = 32; //Field offset: 0x0
	public const sbyte RE_GHEP_DO_OK = 31; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_CAP_FAIL = 30; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_SET_DA_NL = 29; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_SET_DA_SC = 28; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_CAP_OK = 27; //Field offset: 0x0
	public const sbyte RE_DA_SIEU_CAP_DAP = 26; //Field offset: 0x0
	public const sbyte RE_CHE_TAC_CONG_OK = 25; //Field offset: 0x0
	public const sbyte RE_CHE_TAC_CONG_DAP = 24; //Field offset: 0x0
	public const sbyte RE_ITEM_OK_KICH_AN = 22; //Field offset: 0x0
	public const sbyte TRADE_INVITE = 6; //Field offset: 0x0
	public const sbyte CLAN_ADD_REMOVE_LIST_MEM = 12; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_STATUS = 14; //Field offset: 0x0
	public const sbyte EFF_KICK_MA_CA_RONG = 6; //Field offset: 0x0
	public const sbyte EFF_KICK_TAP_TRUNG_CAO_DO = 5; //Field offset: 0x0
	public const sbyte EFF_KICK_BOC_PHA = 4; //Field offset: 0x0
	public const sbyte EFF_KICK_KHOA_NANG_LUONG = 3; //Field offset: 0x0
	public const sbyte EFF_KICK_LA_CHAN = 2; //Field offset: 0x0
	public const sbyte EFF_KICK_LOI_CAM_ON = 1; //Field offset: 0x0
	public const sbyte EFF_KICK_RESET_COUNTDOWN_KICK = 8; //Field offset: 0x0
	public const sbyte EFF_KICK_BAT_TU = 0; //Field offset: 0x0
	public const sbyte EFF_MP_HP_NOR = 0; //Field offset: 0x0
	public const sbyte LOL_LIST_BUFF = 4; //Field offset: 0x0
	public const sbyte LOL_UPDATE_TRU_KD = 3; //Field offset: 0x0
	public const sbyte LOL_TYPE_PK = 1; //Field offset: 0x0
	public const sbyte LOL_UPDATE_TYPE_OBJ = 0; //Field offset: 0x0
	public const sbyte LOL_CHAT = 2; //Field offset: 0x0
	public const sbyte EFF_MP_HP_PHAN_DAM = 1; //Field offset: 0x0
	public const sbyte EFF_KICK_RESET_COUNTDOWN_AVA = 9; //Field offset: 0x0
	public const sbyte EFF_KICK_GIAI_PHONG_NANG_LUONG = 10; //Field offset: 0x0
	public const sbyte EFF_KICK_NGUOI_BAT_TU = 11; //Field offset: 0x0
	public const sbyte TYPE_OPEN = 0; //Field offset: 0x0
	private const sbyte ACTION_HANH_TRINH = 4; //Field offset: 0x0
	private const sbyte ACTION_TACH_DA = 3; //Field offset: 0x0
	private const sbyte ACTION_KHAM_DA = 2; //Field offset: 0x0
	private const sbyte ACTION_SEND_INFO_EQUI = 1; //Field offset: 0x0
	private const sbyte ACTION_OPEN = 0; //Field offset: 0x0
	public const sbyte EVENT_ACTION_NAU_BANH_CHUNG_AUDITION_VOT_BANH = 1; //Field offset: 0x0
	public const sbyte EVENT_ACTION_NAU_BANH_CHUNG_AUDITION_NAU = 0; //Field offset: 0x0
	public const sbyte EVENT_TYPE_NAU_BANH_CHUNG_AUDITION = 1; //Field offset: 0x0
	public const sbyte EVENT_ACTION_TAI_XIU_LICH_SU_VAN = 4; //Field offset: 0x0
	public const sbyte EVENT_ACTION_TAI_XIU_UPDATE = 3; //Field offset: 0x0
	public const sbyte EVENT_ACTION_TAI_XIU_KET_QUA = 2; //Field offset: 0x0
	public const sbyte EVENT_ACTION_TAI_XIU_DAT_CUOC = 1; //Field offset: 0x0
	public const sbyte EVENT_ACTION_OPEN = 0; //Field offset: 0x0
	public const sbyte EVENT_TYPE_TAI_XIU = 0; //Field offset: 0x0
	public const sbyte CHEST_W_DEL = 1; //Field offset: 0x0
	public const sbyte CHEST_W_UPDATE = 0; //Field offset: 0x0
	public const sbyte WANTED_UPDATE_TIME_NEXT = 5; //Field offset: 0x0
	public const sbyte WANTED_UPDATE_POINT = 4; //Field offset: 0x0
	public const sbyte LITTLE_UPDATE_MP_HP = 1; //Field offset: 0x0
	public const sbyte LITTLE_CREATE_BOSS = 0; //Field offset: 0x0
	public const sbyte CHUYENHOA_UPDATE_PRICE = 2; //Field offset: 0x0
	public const sbyte CHUYENHOA_END = 3; //Field offset: 0x0
	public const sbyte CHUYENHOA_IMPORT_ITEM = 1; //Field offset: 0x0
	public const sbyte CHUYENHOA_OPEN = 0; //Field offset: 0x0
	public const sbyte UPDATECHAT_ADD = 1; //Field offset: 0x0
	public const sbyte UPDATECHAT_ALL = 0; //Field offset: 0x0
	public const sbyte CLAN_CLOSE_CREATE_CLAN = 21; //Field offset: 0x0
	public const sbyte CLAN_THONGBAO_CUP = 20; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_INVEN_CLAN = 19; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_INFO_MEM_CLAN = 18; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_MONEY = 17; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_XP = 16; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_ATTRIBUTE_PLUS_PLAYER = 15; //Field offset: 0x0
	public const sbyte LITTLE_BOSS_FIGHT = 2; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_TIME_DONATE = 13; //Field offset: 0x0
	public const sbyte LITTLE_BOSS_DIE = 3; //Field offset: 0x0
	public const sbyte PET_REMOVE = 1; //Field offset: 0x0
	public const sbyte WANTED_CANCLE = 3; //Field offset: 0x0
	public const sbyte WANTED_READY = 2; //Field offset: 0x0
	public const sbyte WANTED_FIND = 1; //Field offset: 0x0
	public const sbyte WANTED_OPEN = 0; //Field offset: 0x0
	public const sbyte MAX_OPEN = 2; //Field offset: 0x0
	public const sbyte MAX_UPDATE_ONE = 1; //Field offset: 0x0
	public const sbyte MAX_UPDATE_ALL = 0; //Field offset: 0x0
	public const sbyte PVP_LOSE = 4; //Field offset: 0x0
	public const sbyte PVP_WIN = 3; //Field offset: 0x0
	public const sbyte PVP_START = 2; //Field offset: 0x0
	public const sbyte PVP_3_SECOND = 1; //Field offset: 0x0
	public const sbyte PVP_READY = 0; //Field offset: 0x0
	public const sbyte PET_USE = 4; //Field offset: 0x0
	public const sbyte PET_INVEN = 3; //Field offset: 0x0
	public const sbyte PET_USE_SKILL = 2; //Field offset: 0x0
	public const sbyte PET_CREATE = 0; //Field offset: 0x0
	public const sbyte TRADE_CANCEL = 5; //Field offset: 0x0
	public const sbyte TYPE_SEND_QUA = 2; //Field offset: 0x0
	public const sbyte TRADE_LOCK = 3; //Field offset: 0x0
	public const sbyte EFF_CHOPPER_BUFF = 6; //Field offset: 0x0
	public const sbyte EFF_LITTLE_BUFF_HP = 7; //Field offset: 0x0
	public const sbyte EFF_LITTLE_BUFF_HP_BOSS = 8; //Field offset: 0x0
	public const sbyte EFF_LITTLE_DAM_BOSS = 9; //Field offset: 0x0
	public const sbyte EFF_WAPOL = 10; //Field offset: 0x0
	public const sbyte EFF_BI_BE = 11; //Field offset: 0x0
	public const sbyte EFF_NEM_POKE_OK = 12; //Field offset: 0x0
	public const sbyte EFF_NEM_POKE_FAIL = 13; //Field offset: 0x0
	public const sbyte EFF_LOL_TRU_TREN = 14; //Field offset: 0x0
	public const sbyte EFF_LOL_TRU_DUOI = 15; //Field offset: 0x0
	public const sbyte EFF_CHOANG = 16; //Field offset: 0x0
	public const sbyte EFF_KIET_SUC = 17; //Field offset: 0x0
	public const sbyte EFF_BAT_TU = 18; //Field offset: 0x0
	public const sbyte EFF_KHANG_TAT_CA = 19; //Field offset: 0x0
	public const sbyte EFF_THA_DEN = 20; //Field offset: 0x0
	public const sbyte EFF_TU_CHOI_TU_THAN = 21; //Field offset: 0x0
	public const sbyte EFF_LIGHTING_RED = 22; //Field offset: 0x0
	public const sbyte EFF_THA_PHAO_HOA = 23; //Field offset: 0x0
	public const sbyte TRADE_OK = 4; //Field offset: 0x0
	public const sbyte EFF_GOAL = 25; //Field offset: 0x0
	public const sbyte EFF_DECREASE_POWER = 26; //Field offset: 0x0
	public const sbyte EFF_EVENT_POKE = 27; //Field offset: 0x0
	public const sbyte EFF_HAKI = 28; //Field offset: 0x0
	public const sbyte EFF_TEST_SKILL_ID = 29; //Field offset: 0x0
	public const sbyte EFF_KIZURA = 30; //Field offset: 0x0
	public const sbyte ACTION_LIST = 0; //Field offset: 0x0
	private const sbyte ACTION_INVEN = 1; //Field offset: 0x0
	private const sbyte ACTION_USE = 2; //Field offset: 0x0
	private const sbyte ACTION_MO_HH = 3; //Field offset: 0x0
	public const sbyte EFF_PHAN_DAM_ZORO = 5; //Field offset: 0x0
	public const sbyte TYPE_MO_HH_MENU = 0; //Field offset: 0x0
	public const sbyte EFF_BOOM_USSOP = 4; //Field offset: 0x0
	public const sbyte EFF_GET_MONEY_VUON_CAM = 2; //Field offset: 0x0
	public const sbyte REMOVE_TELEPORT = 1; //Field offset: 0x0
	public const sbyte REMOVE_LINK_MAP = 2; //Field offset: 0x0
	public const sbyte REMOVE_MAP_SEA = 3; //Field offset: 0x0
	public const sbyte DIALOG_CLOSE = 0; //Field offset: 0x0
	public const sbyte DIALOG_DOWNLOAD = 1; //Field offset: 0x0
	public const sbyte DIALOG_NORMAL = 2; //Field offset: 0x0
	public const sbyte DIALOG_TIME = 3; //Field offset: 0x0
	public const sbyte DIALOG_RUBY = 4; //Field offset: 0x0
	public const sbyte UPDATE_ALL = 0; //Field offset: 0x0
	public const sbyte ADD_REPLACE = 1; //Field offset: 0x0
	public const sbyte DELETE = 2; //Field offset: 0x0
	public const sbyte UPDATE_MONEY = 3; //Field offset: 0x0
	public const sbyte SIZE_CHEST = 6; //Field offset: 0x0
	public const sbyte SHOP_MATERIAL = 6; //Field offset: 0x0
	public const sbyte INVEN = 100; //Field offset: 0x0
	public const sbyte CHEST = 99; //Field offset: 0x0
	public const sbyte SHIP = 101; //Field offset: 0x0
	public const sbyte BOAT = 102; //Field offset: 0x0
	public const sbyte HAIR = 103; //Field offset: 0x0
	public const sbyte FASHION = 105; //Field offset: 0x0
	public const sbyte INVEN_CLAN = 110; //Field offset: 0x0
	public const sbyte SHOP_DA_KHAM = 111; //Field offset: 0x0
	public const sbyte HEAD = 112; //Field offset: 0x0
	public const sbyte FASHION_EVENT = 113; //Field offset: 0x0
	public const sbyte FASHION_GIFT_EVENT = 114; //Field offset: 0x0
	public const sbyte SHOP_EVENT = 116; //Field offset: 0x0
	public const sbyte DIEM_TICH_LUY = 118; //Field offset: 0x0
	public const sbyte EFF_LV_UP = 0; //Field offset: 0x0
	public const sbyte EFF_HOA_THU = 1; //Field offset: 0x0
	public const sbyte EFF_SET_NAMI = 3; //Field offset: 0x0
	private const sbyte TYPE_MO_HH_OPEN = 1; //Field offset: 0x0
	public const sbyte EFF_LAW_HEART = 24; //Field offset: 0x0
	public const sbyte MENU_IMAGE = 1; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_LUCKY = 5; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_BAOHIEM = 6; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_UPGRADE = 7; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_SHOP_MATERIAL = 8; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_KHAM = 9; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_DUT = 10; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_SHOP_DA = 11; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_GHEP_DA = 12; //Field offset: 0x0
	public const sbyte MENU_NORMAL = 0; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_BAO_HIEM_2 = 14; //Field offset: 0x0
	public const sbyte UPGRADE_LAW_HEART = 15; //Field offset: 0x0
	public const sbyte UPGRADE_LAW_HEART_THANH_CONG = 16; //Field offset: 0x0
	public const sbyte UPGRADE_LAW_HEART_THAT_BAI = 17; //Field offset: 0x0
	public const sbyte ACTION_OPEN_MENU = 0; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_ITEM = 4; //Field offset: 0x0
	public const sbyte ACTION_SET_ITEM = 1; //Field offset: 0x0
	public const sbyte ACTION_SUCC = 3; //Field offset: 0x0
	public const sbyte ACTION_HOI_NANG_CAP = 4; //Field offset: 0x0
	public const sbyte ACTION_UPDATE_LIST = 5; //Field offset: 0x0
	public const sbyte ACTION_HE_SO_AN = 6; //Field offset: 0x0
	public const sbyte SPLIT_TYPE_SPLIT = 0; //Field offset: 0x0
	public const sbyte SPLIT_TYPE_JOIN = 1; //Field offset: 0x0
	public const sbyte SPLIT_ACTION_BO_VAO = 0; //Field offset: 0x0
	public const sbyte SPLIT_ACTION_XONG = 1; //Field offset: 0x0
	public const sbyte SPLIT_ACTION_LOI = 2; //Field offset: 0x0
	public const sbyte SPLIT_ACTION_OPEN_SPLIT = 3; //Field offset: 0x0
	public const sbyte SPLIT_ACTION_OPEN_MENU_SPLIT = 4; //Field offset: 0x0
	public const sbyte TRADE_OPEN = 0; //Field offset: 0x0
	public const sbyte TRADE_SET_ITEM = 1; //Field offset: 0x0
	public const sbyte TRADE_CHAT = 2; //Field offset: 0x0
	public const sbyte ACTION_CUONG_HOA = 2; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_THAT_BAI = 3; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_OPEN_TACH_DA = 13; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_HOI = 1; //Field offset: 0x0
	public const sbyte MENU_NPC = 2; //Field offset: 0x0
	public const sbyte MENU_ITEM = 3; //Field offset: 0x0
	public const sbyte MENU_SKILL = 4; //Field offset: 0x0
	public const sbyte MENU_IMAGE_NEW = 5; //Field offset: 0x0
	public const sbyte MENU_IMAGE_COLOR = 6; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_THANH_CONG = 2; //Field offset: 0x0
	public const sbyte STATUS_QUEST_MAP = 1; //Field offset: 0x0
	public const sbyte QUEST_ALL = 0; //Field offset: 0x0
	public const sbyte QUEST_ADD = 1; //Field offset: 0x0
	public const sbyte QUEST_DEL = 2; //Field offset: 0x0
	public const sbyte QUEST_FINISH = 3; //Field offset: 0x0
	public const sbyte QUEST_ACTION_FINISH = 4; //Field offset: 0x0
	public const sbyte PARTY_INVITE = 0; //Field offset: 0x0
	public const sbyte PARTY_ADD = 1; //Field offset: 0x0
	public const sbyte PARTY_DEL = 2; //Field offset: 0x0
	public const sbyte QUEST_ACTION_SHOW_DIALOG = 5; //Field offset: 0x0
	public const sbyte PARTY_CANCEL = 3; //Field offset: 0x0
	public const sbyte PARTY_APPCEPT = 4; //Field offset: 0x0
	public const sbyte PARTY_CREATE = 5; //Field offset: 0x0
	public const sbyte UPGRADE_STEP_LOI = 0; //Field offset: 0x0
	public const sbyte SKILL_DEL = 3; //Field offset: 0x0
	public const sbyte PARTY_APPCEPT_ADD = 6; //Field offset: 0x0
	public const sbyte PARTY_XIN_VAO = 7; //Field offset: 0x0
	public const sbyte SKILL_LEARN = 0; //Field offset: 0x0
	public const sbyte SKILL_ADD = 1; //Field offset: 0x0
	public const sbyte SKILL_UPDATE_XP = 2; //Field offset: 0x0
	public static iCommand cmdOffChat; //Field offset: 0x8
	public static iCommand cmdOffName; //Field offset: 0x10
	public static iCommand cmdOffAll; //Field offset: 0x18
	public static iCommand cmdShowPos; //Field offset: 0x20
	public static iCommand cmdShowSysout; //Field offset: 0x28
	public static iCommand cmdShowIpLocal; //Field offset: 0x30
	public static iCommand cmdShowInTabAdmin; //Field offset: 0x38
	public static iCommand cmdSetSkillEff15; //Field offset: 0x40
	public static iCommand cmdSetSkillEff20; //Field offset: 0x48
	public static sbyte actionChangeMap; //Field offset: 0x50
	public static bool isNondata; //Field offset: 0x51
	public static short indexHotKeySkill; //Field offset: 0x52
	public static short IdDialog; //Field offset: 0x54
	public static short idItemUpgrade; //Field offset: 0x56
	public static int yBoatMap; //Field offset: 0x58
	public static SByte[] mtest; //Field offset: 0x60
	public static short IDDialogPhoBang; //Field offset: 0x68
	public static mImage[] mImgCapredLine; //Field offset: 0x70
	public static short idLvthap; //Field offset: 0x78
	public static short idLvCao; //Field offset: 0x7A
	public static sbyte numCuonghoa; //Field offset: 0x7C
	public static int timeLoadItemMap; //Field offset: 0x80
	public static sbyte ID_GiaoTiep_Server; //Field offset: 0x84
	public static string Str_GiaoTiep_Server; //Field offset: 0x88
	private Int16[][] hardcodeSkill5; //Field offset: 0x40
	private Int16[][] hardcodeSkill10; //Field offset: 0x48
	private Int16[][] hardcodeSkill15; //Field offset: 0x50
	private Int16[][] hardcodeSkill20; //Field offset: 0x58
	public Message msgLuu; //Field offset: 0x60
	public short idMapLuu; //Field offset: 0x68
	private int lechYNum; //Field offset: 0x6C

	private static ReadMessenge() { }

	public ReadMessenge() { }

	public void addHP_EffSkill(Message msg) { }

	public void Archi_Daily(Message msg) { }

	public void AreaStatus(Message msg) { }

	public void Auto_Revice(Message msg) { }

	public void Boat_In_Map(Message msg) { }

	public void Buff(Message msg) { }

	public void Buy_Item_Shop(Message msg) { }

	public void Buy_Potion_Ok(Message msg) { }

	public void ChangeArea(Message msg) { }

	public void ChangeMap(Message msg) { }

	public void ChangeMapNonData(Message msg) { }

	public void char_info(Message msg) { }

	public void charWearing(Message msg) { }

	public void ChatPopup(Message msg) { }

	public void ChatTab(Message msg) { }

	public void check_AFK(Message msg) { }

	public void Check_Data_Ver(Message msg) { }

	public bool check_IDMap_PVP() { }

	public void ChestWanted(Message msg) { }

	public void ChuyenHoa(Message msg) { }

	public void Clan(Message msg) { }

	public void Clan_Fight(Message msg) { }

	public void CMD_test(Message msg) { }

	public void cmdEvent(Message msg) { }

	public void comboSkill(Message msg) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void Count_Kick_Ava(Message msg) { }

	public void CountDown_Ticket(Message msg) { }

	public void daily_Bonus(Message msg) { }

	public void dataListServer(Message msg) { }

	public void Del_Char(Message msg) { }

	public void Dialog_More_server(Message msg) { }

	public void Diaolog_time(Message msg) { }

	public void diePlayer(Message msg) { }

	public void disconnect_Why(Message msg) { }

	public void DonotAutoReconnect(Message msg) { }

	public void Dynamic_Menu(Message msg) { }

	public void Eff_Kich_An(Message msg) { }

	public void Effect_Obj(Message msg) { }

	public void Event(Message msg) { }

	public void Fight(Message msg) { }

	public void Fire_Object(Message msg) { }

	public void Fire_Object_NEW(Message msg) { }

	public void Friend(Message msg) { }

	public void Frist_Login(Message msg) { }

	private void Get_Data_Char_Part(Message msg) { }

	private void Get_Data_Item_Map(Message msg) { }

	private void Get_Data_Name_Map(Message msg) { }

	private void Get_Data_Name_Potion_Quest(Message msg) { }

	private void Get_Data_Upgrade(Message msg) { }

	public void get_Info_NPC(Message msg) { }

	public void Get_Monster_Tem(Message msg) { }

	private void Get_Name_Attributes(Message msg) { }

	private void Get_Potion_Tem(Message msg, sbyte typePotion) { }

	private void Get_Skill_Player(Message msg) { }

	public void Get_Xp_Map_Train(Message msg) { }

	public void getDamList(Message msg) { }

	public void getData(Message msg) { }

	public void getDataEff(Message msg) { }

	public void getDataInfoPotion(Message msg) { }

	public void getInfoClanDao(Message msg) { }

	public void getInfoEquip() { }

	public void GetItemMap(Message msg) { }

	public void GetItemMapLittle(Message msg) { }

	public void getTemplate(Message msg) { }

	public void getThanhTich(Message msg) { }

	public void ghost(Message msg) { }

	public void GiaoTiep_FormServer(Message msg) { }

	public void gps(Message msg) { }

	public void Hanh_Trinh(Message msg) { }

	public void Help_From_Server(Message msg) { }

	public void infoFashion(Message msg) { }

	public void Input_password(Message msg) { }

	public void Input_server(Message msg) { }

	public void Item_Drop(Message msg) { }

	public void Join_Item(Message msg) { }

	public void Learn_Skill(Message msg) { }

	public void List_NPC(Message msg) { }

	public void List_Player_Check(Message msg) { }

	public void List_Quest(Message msg) { }

	public void ListChar(Message msg) { }

	public void ListDauGia(Message msg) { }

	public void listGiftArea(Message msg) { }

	public void ListPlayerServer(Message msg) { }

	public void ListTichCongDon(Message msg) { }

	public void ListTichNapThe(Message msg) { }

	public void ListTichTieu(Message msg) { }

	public void ListWantedServer(Message msg) { }

	public void ListWantedServerTypeViewInfo(Message msg, sbyte type) { }

	public void little_Garden(Message msg) { }

	public void loadDataEff(Message msg) { }

	public void loadImage(Message msg) { }

	public void LoadImageAndroidOk(Message msg) { }

	public void LoadImageNew(Message msg) { }

	public void LoadRedLine(bool isFinish) { }

	public void login_Ok(Message msg) { }

	public void Main_char_Info(Message msg) { }

	public void Market(Message msg) { }

	public void Max_Level(Message msg) { }

	public void MonsterDie(Message msg) { }

	public void monsterInfo(Message msg) { }

	public void MonsterNoneFocus(Message msg) { }

	public void Nap_The(Message msg) { }

	public void NewDialog(Message msg) { }

	public void Notify_Server(Message msg) { }

	public void NumItemQuest(Message msg) { }

	public void ObjectMove(Message msg) { }

	public void Ok_Change_Map_Link(Message msg) { }

	public void Open_Box(Message msg) { }

	public void openGhepnhieu(Message msg) { }

	public void OpenMessenger(Message msg) { }

	public void Party(Message msg) { }

	public void Party_Buff(Message msg) { }

	public void Pet(Message msg) { }

	public void Potion_Choice(Message msg) { }

	public void PvP(Message msg) { }

	public void PvP_Thong_Bao(Message msg) { }

	public void Quay_oc_sen(Message msg) { }

	public void Quay_So(Message msg) { }

	public void Quay_WC(Message msg) { }

	private MainQuest QuestAdd(Message msg) { }

	private MainQuest QuestCurrent(Message msg) { }

	private MainQuest QuestFinish(Message msg) { }

	public void QuickChat(Message msg) { }

	public void read_Data_Chat(Message msg, int tab) { }

	public void Read_Sudo(Message msg) { }

	public void readAttribute(Message msg) { }

	public void readChangeMapNew(Message msg, short idmap) { }

	public void readChangeMapNonData(Message msg, short idmap) { }

	public void ReadEventTrangTri(Message msg) { }

	public InfoMemList ReadInfoClanList(Message msg) { }

	public InfoMemList ReadInfoMemList(Message msg) { }

	public InfoMemList ReadInfoMemListWanted(Message msg) { }

	public InfoMemList ReadInfoMemWantedWarrant(Message msg) { }

	private void readMemInCLan(Message msg) { }

	public void ReadPartNew(Message msg) { }

	public Skill_Info readSkillInfo(Message msg) { }

	public void ReadTrongCay(Message msg) { }

	public Item readUpdateItem(Message msg, bool isShop) { }

	public ItemBoat readUpdateItemBoat(Message msg) { }

	public ItemFashion readUpdateItemFashion(Message msg) { }

	public ItemHair readUpdateItemHair(Message msg, sbyte typeObj) { }

	public MainMaterial readUpdateMaterial(Message msg, bool isShop) { }

	public Potion readUpdatePotion(Message msg, bool isShop, sbyte cat) { }

	public MainItem readUpdatePotionMarket(Message msg, sbyte cat) { }

	public Quest_Potion readUpdateQuestPotion(Message msg) { }

	public void RebuildItem(Message msg) { }

	public void Red_Line(Message msg) { }

	public void Register(Message msg) { }

	public void registerNew(Message msg) { }

	public void remove_Char(Message msg) { }

	public void remove_Obj(Message msg) { }

	public static void resetPlayer() { }

	public void resetValueUpdateImage(Message msg) { }

	public void Revice_Player(Message msg) { }

	public void Save_RMS_Server(Message msg) { }

	public void SaveImageAndroid(Message msg) { }

	public void Set_XP(Message msg) { }

	public void Set_XP_Skill(Message msg) { }

	private void setEffSkill10(int subIndex) { }

	private void setEffSkill15(int subIndex) { }

	private void setEffSkill20(int subIndex) { }

	private void setEffSkill5(int subIndex) { }

	public iCommand setfraIComment(sbyte type, short idImage, iCommand cmd) { }

	private void setHelp() { }

	public void SetImage(mImage img, short id) { }

	public void SetImage(mImage img, sbyte type, short id) { }

	private iCommand setImgCmdNew(iCommand cmd, sbyte IdImg) { }

	private bool setMapSea(int id) { }

	private void setUpLv() { }

	public void setWeather(Message msg) { }

	public void Ship(Message msg) { }

	public void Shop_IconClanVip(Message msg) { }

	public void Shop_NPC(Message msg) { }

	public void ShowInfoPlayer(Message msg) { }

	public void Skill_Map_Train(Message msg) { }

	public void SkillSpec(Message msg) { }

	public void Split_Item(Message msg) { }

	public void Split_Join_Item(Message msg) { }

	public void Table_Match(Message msg) { }

	public void Teleport_Boss(Message msg) { }

	public void Thanh_Toan(Message msg) { }

	public void TimeItemDrop(Message msg) { }

	public void TimeShow(Message msg) { }

	public void title_Map_Fight(Message msg) { }

	public void Trade(Message msg) { }

	public void TypeNpcEvent(Message msg) { }

	public void update_Chest(Message msg) { }

	public void update_Inven_Clan(Message msg) { }

	public void update_InVen_Or_Chest(Message msg, mVector vec, sbyte typeInvenOrChest) { }

	public void update_Inventory(Message msg) { }

	public void update_List_Pk(Message msg) { }

	public void update_MP_HP(Message msg) { }

	public void update_MP_HP_Eff(Message msg) { }

	public void update_Part_Boat(Message msg) { }

	public void update_PK(Message msg) { }

	public void update_Pk_Point(Message msg) { }

	private void Update_Potion_Tem(Message msg, sbyte typePotion) { }

	public void Update_User_Ok(Message msg) { }

	public void updateIndexView() { }

	public void UpdateInfoMaincharInfo(Message msg) { }

	public void UpdateLoL(Message msg) { }

	public void updateMoney(long xu, int luong, short ticket) { }

	public void UpdateNameNPC(Message msg) { }

	public void updateNumPlayerMap(Message msg) { }

	public void updatePoint_WorldWar(Message msg) { }

	public void UpdatePvpPoint(Message msg) { }

	public void updateXP_Arena(Message msg) { }

	public void Upgrade_Dial(Message msg) { }

	public void Upgrade_Item(Message msg) { }

	public void Upgrade_Skin(Message msg) { }

	public void upgradeDevil(Message msg) { }

	public void UpgradeSuper_Item(Message msg) { }

	public void use_Potion(Message msg) { }

	public void vongsinhtu(Message msg) { }

	public void Wanted(Message msg) { }

	public void Weapon_fashion(Message msg) { }

}

