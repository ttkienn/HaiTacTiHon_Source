//Type is in global namespace

public class GlobalService : Cmd_Message
{
	protected static GlobalService instance; //Field offset: 0x0
	public const sbyte MARKET_PAGE = 1; //Field offset: 0x0
	public const sbyte MARKET_BUY = 0; //Field offset: 0x0
	public const sbyte PAINT_WEAPON_FASHION = 1; //Field offset: 0x0
	public const sbyte PAINT_HAT = 0; //Field offset: 0x0
	public const sbyte CLAN_UPDATE_LIST_MEM = 17; //Field offset: 0x0
	public const sbyte CLAN_NO_ACCEPT_JOIN_CLAN = 16; //Field offset: 0x0
	public const sbyte CLAN_NAP_TIEN = 15; //Field offset: 0x0
	public const sbyte CLAN_USE_POTION = 14; //Field offset: 0x0
	public const sbyte CLAN_LEVEL_UP = 13; //Field offset: 0x0
	public const sbyte CLAN_NHAN_LOI_MOI = 12; //Field offset: 0x0
	public const sbyte CLAN_XIN_VAO_CLAN = 11; //Field offset: 0x0
	public const sbyte CLAN_MOI_VAO_CLAN = 10; //Field offset: 0x0
	public const sbyte CLAN_REQUEST_DATA_CLAN = 9; //Field offset: 0x0
	public const sbyte CLAN_ACCEPT_JOIN_CLAN = 7; //Field offset: 0x0
	public const sbyte CLAN_ATTRI = 6; //Field offset: 0x0
	public const sbyte CLAN_STATUS = 5; //Field offset: 0x0
	public const sbyte CLAN_LEAVE = 4; //Field offset: 0x0
	public const sbyte CLAN_PHONG_CHUC = 3; //Field offset: 0x0
	public const sbyte CLAN_DONATE = 2; //Field offset: 0x0
	public const sbyte CLAN_KICK = 1; //Field offset: 0x0
	public const sbyte CLAN_CHAT_ALL = 0; //Field offset: 0x0
	public const sbyte SHIP_ERROR = 2; //Field offset: 0x0
	public const sbyte SHIP_START = 1; //Field offset: 0x0
	public const sbyte SHIP_CHANGE = 0; //Field offset: 0x0
	public const sbyte TYPE_FIGHT_BATTLE = 1; //Field offset: 0x0
	public const sbyte TYPE_FIGHT_NORMAL = 0; //Field offset: 0x0
	public const sbyte FIGHT_ACC = 1; //Field offset: 0x0
	public const sbyte MARKET_OPEN = 2; //Field offset: 0x0
	public const sbyte FIGHT_REQUEST = 0; //Field offset: 0x0
	public const sbyte MARKET_UPDATE = 3; //Field offset: 0x0
	public const sbyte MARKET_SEND_TO_INVEN = 5; //Field offset: 0x0
	public const sbyte SUDO_ACCEPT_JOIN_CLAN = 18; //Field offset: 0x0
	public const sbyte SUDO_LEAVE = 17; //Field offset: 0x0
	public const sbyte SUDO_KICK = 16; //Field offset: 0x0
	public const sbyte SUDO_CHAT_ALL = 15; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_LIST_MEM_CLAN = 6; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_REQUEST_FIGHT_CLAN = 5; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_ERROR = 4; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_REQUEST_AUTO = 3; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_NO_ACCEPT = 2; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_ACCEPT = 1; //Field offset: 0x0
	public const sbyte CLAN_FIGHT_REQUEST_LIST_CLAN = 0; //Field offset: 0x0
	public const sbyte QUAY_BUY = 4; //Field offset: 0x0
	public const sbyte QUAY_REQUEST = 3; //Field offset: 0x0
	public const sbyte QUAY_3_LAN = 2; //Field offset: 0x0
	public const sbyte QUAY_1_LAN = 1; //Field offset: 0x0
	public const sbyte ACTION_QUA_THA_TROI = 4; //Field offset: 0x0
	public const sbyte ACTION_OPEN = 3; //Field offset: 0x0
	public const sbyte ACTION_UPDATE_TRANG_TRI = 2; //Field offset: 0x0
	public const sbyte ACTION_DOI_QUA = 1; //Field offset: 0x0
	public const sbyte ACTION_GET_MENU_TRANG_TRI = 0; //Field offset: 0x0
	public const sbyte EVENT_MERRY_CM = 0; //Field offset: 0x0
	public const sbyte MARKET_SELL_ANY_ITEM_FORM_CHEST = 11; //Field offset: 0x0
	public const sbyte MARKET_SELL_ANY_ITEM_FORM_INVEN = 10; //Field offset: 0x0
	public const sbyte MARKET_UPDATE_SHOP_ANY_ITEM = 9; //Field offset: 0x0
	public const sbyte MARKET_REQUEST_PAGE = 8; //Field offset: 0x0
	public const sbyte MARKET_SELL_CHEST = 7; //Field offset: 0x0
	public const sbyte MARKET_CANCLE_SELL = 6; //Field offset: 0x0
	public const sbyte MARKET_SELL = 4; //Field offset: 0x0
	public const sbyte SUDO_XIN_VAO_CLAN = 19; //Field offset: 0x0
	public const sbyte UPGRADE_CHEST = 5; //Field offset: 0x0
	public const sbyte GET_CHEST_TO_INVEN = 2; //Field offset: 0x0
	public const sbyte UP_DATE_DATA_SKILL = 30; //Field offset: 0x0
	public const sbyte UP_DATE_DATA_POTION_CLAN = 29; //Field offset: 0x0
	public const sbyte UPDATE_DATA_POTION = 28; //Field offset: 0x0
	public const sbyte IS_CHIEM_DAO = 27; //Field offset: 0x0
	public const sbyte DATA_ATTRI_KICH_AN = 26; //Field offset: 0x0
	public const sbyte DATA_POTION_NEW = 24; //Field offset: 0x0
	public const sbyte DATA_PART_IMAGE_NEW = 23; //Field offset: 0x0
	public const sbyte DATA_OFF_NAME = 22; //Field offset: 0x0
	public const sbyte DATA_END_TT = 21; //Field offset: 0x0
	public const sbyte DATA_POTION_CLAN = 18; //Field offset: 0x0
	public const sbyte DATA_CLOCK_SERVER = 17; //Field offset: 0x0
	public const sbyte DATA_TILE_CUONGHOA = 19; //Field offset: 0x0
	public const sbyte DATA_SEA = 13; //Field offset: 0x0
	public const sbyte DATA_UPGRADE = 12; //Field offset: 0x0
	public const sbyte DATA_MATERIAL = 11; //Field offset: 0x0
	public const sbyte DATA_MAP_LANG = 10; //Field offset: 0x0
	public const sbyte DATA_ITEM_MAP = 9; //Field offset: 0x0
	public const sbyte DATA_SELL_SHOP = 8; //Field offset: 0x0
	public const sbyte DATA_NAME_POTION_QUEST = 7; //Field offset: 0x0
	public const sbyte DATA_NAME_MAP = 6; //Field offset: 0x0
	public const sbyte DATA_CHAR_PART = 5; //Field offset: 0x0
	public const sbyte DATA_LOCK_MAP = 4; //Field offset: 0x0
	public const sbyte DATA_SKILL = 3; //Field offset: 0x0
	public const sbyte DATA_NAME_ATTRIBUTES = 2; //Field offset: 0x0
	public const sbyte DATA_POTION_FULL = 1; //Field offset: 0x0
	public const sbyte DATA_POTION = 25; //Field offset: 0x0
	public const sbyte DATA_MONSTER = 15; //Field offset: 0x0
	public const sbyte DATA_EFF_HAIR = 31; //Field offset: 0x0
	public const sbyte REMOVE_FROM_CHEST = 4; //Field offset: 0x0
	public const sbyte SUDO_NO_ACCEPT_JOIN_CLAN = 20; //Field offset: 0x0
	public const string STRING_NAMEMAP = "dataNameMap"; //Field offset: 0x0
	public const string STRING_NAMEPOTIONQUEST = "dataNamePotionquest"; //Field offset: 0x0
	public const string STRING_DATA_UPGRADE = "dataUpgradeSave"; //Field offset: 0x0
	public const string STRING_CHARPART = "dataCharPart"; //Field offset: 0x0
	public const string STRING_ATTRI = "dataAttri"; //Field offset: 0x0
	public const string STRING_POTION = "dataPotion"; //Field offset: 0x0
	public const string STRING_MONSTER = "dataMon"; //Field offset: 0x0
	public const string STRING_POTION_CLAN = "dataPotionClan"; //Field offset: 0x0
	public const sbyte DATA_LIST_POTION_OPEN = 1; //Field offset: 0x0
	public const sbyte DATA_LIST_MONSTER_POKEMON = 2; //Field offset: 0x0
	public const sbyte DATA_LIST_POTION_KHAM = -7; //Field offset: 0x0
	public const sbyte FRIEND_REQUEST = 0; //Field offset: 0x0
	public const sbyte FRIEND_DEL = 1; //Field offset: 0x0
	public const sbyte FRIEND_LIST = 2; //Field offset: 0x0
	public const sbyte FRIEND_ACCEPT = 3; //Field offset: 0x0
	public const sbyte SET_INVEN_TO_CHEST = 1; //Field offset: 0x0
	public const string STRING_ITEMMAP = "dataItemMap"; //Field offset: 0x0
	public const string STRING_IMAGE_SAVE = "dataImageSave"; //Field offset: 0x0
	public static bool isGetMaterial; //Field offset: 0x8
	public static bool isGetKichAn; //Field offset: 0x9
	public static short VerMonster; //Field offset: 0xA
	public static short VerPotion; //Field offset: 0xC
	public static short VerNameAtribute; //Field offset: 0xE
	public static short VerNameMap; //Field offset: 0x10
	public static short VerCharPar; //Field offset: 0x12
	public static short VerNamePotionQuest; //Field offset: 0x14
	public static short VerItemMap; //Field offset: 0x16
	public static short VerImageSave; //Field offset: 0x18
	public static short VerDataUpgrade; //Field offset: 0x1A
	public static short verPotionClan; //Field offset: 0x1C

	public GlobalService() { }

	public void Add_Point_Attribute(sbyte index, short value) { }

	public void Add_Point_Skill(short ID, short value) { }

	public void Archi_Daily(sbyte index, sbyte type) { }

	public void Auto_revice(sbyte type) { }

	public void BeginGame() { }

	public void Buff(short IdBuff, sbyte cat, mVector vec) { }

	public void Buy_Gem(string str1, string str2) { }

	public void Buy_Item_Potion(sbyte TypeShop, short ID, short value, sbyte cat) { }

	public void changeMapOk() { }

	public void char_info(short id) { }

	public void chatPopup(string text) { }

	public void chatTab(string name, string str) { }

	public void Check_AFK() { }

	public void Check_List_Pho_Bang(sbyte type) { }

	private void checkChangeHair() { }

	public static short CheckEmotion(string str) { }

	public void checkPlayInMap(mVector vec) { }

	public void CheckVersion() { }

	public void Chest(sbyte action, short Id, sbyte cat, int num) { }

	public void Chest_Wanted(sbyte action, short ID) { }

	public void Choice_Dialog_server(short id, sbyte value) { }

	public void ChuyenHoa(sbyte type, short idLeft, short idRight) { }

	public void Clan_CMD(sbyte type, string strChat, int id, sbyte chucvu) { }

	public void Clan_Fight(sbyte action, short idClan, sbyte typeFight) { }

	public void Clan_Fight_List_Mem(sbyte action, mVector vec) { }

	public void cmd_Event(sbyte action) { }

	public void cmd_TrangTri(sbyte type, sbyte action) { }

	public void Create_Char(string name, sbyte clazz, short head, short hair) { }

	public void Daily_Login(sbyte action) { }

	public void Del_Char(sbyte type, short id) { }

	public void Devil_Upgrade(sbyte action, short idItem, sbyte cat, short num) { }

	public void Dynamic_Menu(short idNPC, sbyte idMenu, sbyte index) { }

	public void EventMoon(short id, sbyte type) { }

	public void Exit_View() { }

	public void Fight(sbyte type, short Id, sbyte typeFight) { }

	public void Friend(sbyte type, int Id) { }

	public void Frist_Login(string str) { }

	public void get_DATA(sbyte type) { }

	public void get_Info_Clan_Dao() { }

	public void Get_Info_NPC(short id) { }

	public void Get_Item_Map(short id, sbyte cat) { }

	public void Get_Xp_Map_Train(sbyte type) { }

	public void getDataEffAuto(short id) { }

	public void getDataInfoPotion(short index) { }

	public void getDataPart(short index) { }

	public void getDataSkillEFf(sbyte type, short id) { }

	public void GetTemplate(sbyte type, short value) { }

	public void ghost(sbyte id) { }

	public static GlobalService gI() { }

	public void Giaotiep_FormServer(sbyte action, short idObj, sbyte cat) { }

	public void Hanh_Trinh(sbyte action, short idItem) { }

	public void Huy_hieu(sbyte action, sbyte type, short id) { }

	public void InputServer(short Id, String[] str) { }

	public void Learn_Skill(sbyte typeAction, short Index) { }

	public void List_Skill_Map_Train(short Id) { }

	public void ListFromServer(sbyte type, sbyte IdList, sbyte page) { }

	public void load_image(short id, short cat) { }

	public void Load_Image_New(sbyte type, short id) { }

	public void Login(string user, string pass, sbyte type) { }

	public void Market(sbyte type, sbyte indexMarket, short ID, sbyte cat, short value) { }

	public void monster_info(short id) { }

	public void Move_To_Player(sbyte type, int ID) { }

	public void NextMap(short idMap) { }

	public void Obj_Move(short x, short y) { }

	public void OkChangeMapLink() { }

	public void One_Point_Max_Level(sbyte action, short id) { }

	public void Paint_Client(sbyte type, sbyte value) { }

	public void Party(sbyte type, short id) { }

	public void Player_Fire(short idSkill, sbyte CatBeFire, mVector VecBeFire) { }

	public void Player_Revice(sbyte type) { }

	public void PvP(sbyte action) { }

	public void Quay_oc_sen(sbyte action) { }

	public void Quayso(sbyte action) { }

	public void QuayWC(sbyte action) { }

	public void quest(sbyte action, short id) { }

	public void Quick_Chat_Game(sbyte index) { }

	public void Quick_Chat_LoL(sbyte action, sbyte index, sbyte isCap, string name) { }

	public void rebuild_Item(sbyte type, sbyte action, short idItem, sbyte cat, short num) { }

	public void rebuild_Item(sbyte type, sbyte action, short idItem, sbyte cat, short num, short idBua) { }

	public void rebuild_Item_DIAL(sbyte type, sbyte action, short idItem, sbyte cat, short num, short hammer) { }

	public void Red_Line(sbyte type, sbyte key) { }

	public void reDisconectWhy() { }

	public void Register(string name, string pass) { }

	public void RegisterNew(String[] mstr) { }

	public void Request_Image_Android() { }

	public void Room_Wanted(sbyte action) { }

	public void Save_RMS_Server(sbyte type, sbyte id, SByte[] mdata) { }

	public void Select_Area(sbyte type, sbyte select) { }

	public void Select_Char(short id, sbyte type, short idSupport) { }

	public void Sell_Item(sbyte type, short idItem, sbyte cat, short num) { }

	public void Send_Data_List_Server(sbyte subcmd) { }

	public void send_GPS() { }

	public void Send_Nhan_NapTheScr(sbyte type, sbyte id) { }

	public void Send_Nhan_TichLuyCongDon(sbyte type, short cost) { }

	public void Send_Nhan_TichTieuScr(sbyte type, sbyte id) { }

	public void Send_Pet(sbyte action, sbyte type, short id) { }

	public void Send_Pet(sbyte action) { }

	public void Send_Sudo(sbyte type) { }

	public void Send_Type(sbyte cmd, sbyte type) { }

	public void Send_Type_ID(sbyte cmd, sbyte type, sbyte id) { }

	public void Send_Wanted_Poster(sbyte type, short id) { }

	public void Send_Wanted_Poster_Action(sbyte type, short id, sbyte action) { }

	public void Set_PK(sbyte type, sbyte action) { }

	public void Ship(sbyte action) { }

	public void shop_NPC(short idNPC) { }

	public void Show_Player_Info(string name) { }

	public void Split_Item(sbyte type, sbyte action, short idItem, sbyte cat, short num) { }

	public void startMenuChest() { }

	public void Sudo_CMD(sbyte type, string strChat, int id, sbyte chucvu) { }

	public void TaiXiu(sbyte type, sbyte action) { }

	public void TaiXiu(sbyte type, sbyte action, int tienDatCuoc, sbyte cuaDatCuoc, sbyte isTatTay) { }

	public void Thanh_Toan(string token, string id) { }

	public void Trade(sbyte action, short Id, sbyte cat, int num, string str) { }

	public void Update_Num_Player_Map() { }

	public void Update_Part_Boat() { }

	public void Update_Pk_Point() { }

	public void Upgrade_Dial(sbyte type, short idItem, sbyte bery_gem, sbyte num) { }

	public void Upgrade_Item(sbyte type, short idItem, sbyte bery_gem) { }

	public void Upgrade_Skin(sbyte type, sbyte cat, short idItem, sbyte posItem, sbyte bovao) { }

	public void Upgrade_Skin(sbyte type, short idItem) { }

	public void Upgrade_Skin(sbyte type, mVector listItem) { }

	public void Upgrade_Skin(sbyte type, short idFashion, mVector listItem) { }

	public void Upgrade_Super_Item(sbyte type, short idItem, sbyte bery_gem, sbyte num) { }

	public void Use_Item(short idItem, sbyte cat) { }

	public void Use_Item_BOX_CHOICE(short idItem, sbyte cat, sbyte select) { }

	public void Use_Item_Shop(short id, sbyte typeShop) { }

	public void Use_Poke(short ID, short IDMon) { }

	public void Use_Potion(short id) { }

	public void VotBanhChung(sbyte type, sbyte action, sbyte status) { }

	public void World_Chanel(sbyte type, string text) { }

}

