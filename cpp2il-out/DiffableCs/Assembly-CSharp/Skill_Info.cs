//Type is in global namespace

public class Skill_Info : MainItem
{
	public const sbyte DEVIL_HAKI = 2; //Field offset: 0x0
	public const sbyte DEVIL_FRUIT = 1; //Field offset: 0x0
	public const sbyte DEVIL_NONE = 0; //Field offset: 0x0
	public const sbyte BUFF_ME_DEVIL = 4; //Field offset: 0x0
	public const sbyte BUFF_ENEMY = 3; //Field offset: 0x0
	public const sbyte BUFF_ME_FRIEND = 2; //Field offset: 0x0
	public const sbyte BUFF_ME = 1; //Field offset: 0x0
	public const sbyte SKILL_JOB = 6; //Field offset: 0x0
	public const sbyte SKILL_ACTIVE_SEA = 4; //Field offset: 0x0
	public const sbyte SKILL_PASSIVE = 3; //Field offset: 0x0
	public const sbyte SKILL_BUFF = 2; //Field offset: 0x0
	public const sbyte SKILL_ACTIVE = 1; //Field offset: 0x0
	public static sbyte maxLv; //Field offset: 0x0
	public static Plash plashTest; //Field offset: 0x8
	public sbyte typeSkill; //Field offset: 0xC8
	public sbyte typeBuff; //Field offset: 0xC9
	public sbyte typeDevil; //Field offset: 0xCA
	public short typeEffSkill; //Field offset: 0xCC
	public short perEffSpec; //Field offset: 0xCE
	public short timeEffSpec; //Field offset: 0xD0
	public short indexSkillInServer; //Field offset: 0xD2
	public sbyte idEffSpec; //Field offset: 0xD4
	public sbyte nTarget; //Field offset: 0xD5
	public sbyte nKick; //Field offset: 0xD6
	public short range; //Field offset: 0xD8
	public short manaLost; //Field offset: 0xDA
	public short rangeLan; //Field offset: 0xDC
	public short percentLv; //Field offset: 0xDE
	public int timeDelay; //Field offset: 0xE0
	public int damage; //Field offset: 0xE4
	public mVector vecAtt; //Field offset: 0xE8

	private static Skill_Info() { }

	public Skill_Info(short Index, short Id, short IdImage, sbyte type, sbyte typeBuff, string name, short typeEff, short range, short Lv) { }

	public mVector getActionInven() { }

	public void getData(sbyte nTarget, short rangeLan, int Damage, short Manacost, int CoolDown, sbyte nkick, string Description, sbyte LvCur, short percentLv, sbyte typeDevil) { }

	public static MainImage getImage(short icon) { }

	public static Skill_Info getSkillFromID(short Id) { }

	public string getStrType() { }

	public void paint(mGraphics g, int x, int y) { }

	public static void paintIcon(mGraphics g, int x, int y, short icon, sbyte lvDevil) { }

	private static int partitionIt(mVector actors, int left, int right, int pivot) { }

	public static void quickSortSkill(mVector actors) { }

	private static void recQuickSort(mVector actors, int left, int right) { }

	public void setVecInfo(int w) { }

	private static void swap(mVector actors, int dex1, int dex2) { }

}

