//Type is in global namespace

public class MainMonster : MainObject
{
	public const sbyte MONSTER_MOVE_12 = 0; //Field offset: 0x0
	public static mVector VecCatalogyMonSter; //Field offset: 0x0
	public const sbyte MONSTER_SPEC_BOSS = 2; //Field offset: 0x0
	public const sbyte MONSTER_SPEC_NORMAL = 0; //Field offset: 0x0
	public const sbyte MONSTER_PET_DOG = 21; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_BANH_KEM = 20; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_TRU = 19; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_POKEMON = 18; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_ICE_SNOW = 17; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_BANANA = 16; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_KUNGFU = 15; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_BINGO = 14; //Field offset: 0x0
	public const sbyte MONSTER_SPEC_MINI_BOSS = 1; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_FLY = 12; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_2345 = 2; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_CHOPPER = 13; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_1234 = 4; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_23 = 5; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_012 = 3; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_BUNHIN = 8; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_0MOVE = 9; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_01 = 10; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_2343 = 11; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_123 = 6; //Field offset: 0x0
	public const sbyte MONSTER_MOVE_234 = 1; //Field offset: 0x0
	public static MyHashTable hashMonsterTemplate; //Field offset: 0x8
	public int idCatMonster; //Field offset: 0x468
	public int timeAutoAction; //Field offset: 0x46C
	public int timeRemove; //Field offset: 0x470
	public int frameDie; //Field offset: 0x474
	public int timeBienmat; //Field offset: 0x478
	public int timeRanChangeAction; //Field offset: 0x47C
	public int limitMove; //Field offset: 0x480
	public int limitAttack; //Field offset: 0x484
	public int vyStyleDie; //Field offset: 0x488
	public int vyStyleStand; //Field offset: 0x48C
	public long timedie; //Field offset: 0x490
	public long timeMove; //Field offset: 0x498
	public long timeStand; //Field offset: 0x4A0
	public bool isRunAttack; //Field offset: 0x4A8
	public bool isXuatHien; //Field offset: 0x4A9
	public int timeMaxMoveAttack; //Field offset: 0x4AC
	public long timeBeginMoveAttack; //Field offset: 0x4B0
	public mVector vecEffMapSea; //Field offset: 0x4B8
	public mVector vecEffElite; //Field offset: 0x4C0
	public int timezombie; //Field offset: 0x4C8

	private static MainMonster() { }

	public MainMonster(short ID, int IdCatMonster, sbyte typeMove, string name, int x, int y, int maxHP, int lv, CatalogyMonster cata) { }

	public MainMonster(short ID, short idMain, short idImage, sbyte type) { }

	public MainMonster(short ID, int x, int y) { }

	public virtual void addSkillFire(MainSkill skill, mVector vec) { }

	public void auto_Move() { }

	public void autoMoveFire() { }

	public virtual void beginDie(MainObject objFire) { }

	public override void beginFire() { }

	public static MainMonster createMonster(short ID, int x, int y, short IdCatMonster) { }

	public void DeadFly(int dx, int dy, int time, int vyStyle) { }

	public static CatalogyMonster getCatalogyMonster(int id) { }

	public void getInfo() { }

	public virtual int getTypeMoveMonster() { }

	public static void LoadInfoMonsterAgain() { }

	public void Move_to_Focus() { }

	public void Move_To_Player_Skill() { }

	public void paint() { }

	public void paintAvatarFocus(mGraphics g, int x, int y) { }

	public void paintEffBoss(mGraphics g, int ylech) { }

	public void paintEffElite(mGraphics g) { }

	public virtual void paintOnlyShadown(mGraphics g) { }

	public void resetV() { }

	public override void ReveiceMonster() { }

	public virtual void Reveive() { }

	public void setAddEffElite() { }

	public virtual void setDataBeginSkill(MainSkill skill, mVector vec) { }

	public virtual void setFireObject(int value) { }

	public void setNextSkill() { }

	public void setRevice() { }

	public void setSpeed8Huong(int max) { }

	public virtual void setTouchPoint() { }

	public void startDie() { }

	public static void startMonDeadFly(MainMonster m, int attacker, int typeDie) { }

	public virtual void update() { }

	public virtual void updateActionFire() { }

	public void updateDieMonsterNormal() { }

	public void updateDirFocusPlayer() { }

	public void updateEffElite() { }

	public override void updateEffMapSea() { }

}

