//Type is in global namespace

public class MonsterWalk : MainMonster
{
	public static Int32[][] mMon012; //Field offset: 0x0
	public static Int32[][] mMon234; //Field offset: 0x8
	public static Int32[][] mMon12; //Field offset: 0x10
	public static Int32[][] mMon2345; //Field offset: 0x18
	public static Int32[][] mMon2345Long; //Field offset: 0x20
	public static Int32[][] mMon1234; //Field offset: 0x28
	public static Int32[][] mMon23; //Field offset: 0x30
	public static Int32[][] mMon123; //Field offset: 0x38
	public static Int32[][] mMon0Move; //Field offset: 0x40
	public static Int32[][] mMonBuNhin; //Field offset: 0x48
	public static Int32[][] mMonMove01; //Field offset: 0x50
	public static Int32[][] mMon2343; //Field offset: 0x58
	public static Int32[][] mMonBingo; //Field offset: 0x60
	public static Int32[][] mMonKungfu; //Field offset: 0x68
	public static Int32[][] mMon1232; //Field offset: 0x70
	public static Int32[][] mMonIceSnow; //Field offset: 0x78
	public static Int32[][] mMonPokemon; //Field offset: 0x80
	public static Int32[][] mMonTru; //Field offset: 0x88
	public static Int32[][] mMonBanhKem; //Field offset: 0x90
	public static Int32[][] mMonLoSuoi; //Field offset: 0x98
	private int dirLastCur; //Field offset: 0x4D0
	private int tickQuaydau; //Field offset: 0x4D4
	private bool isFly; //Field offset: 0x4D8
	private sbyte isAddEff; //Field offset: 0x4D9
	private int lastTick; //Field offset: 0x4DC
	private int framepaint; //Field offset: 0x4E0

	private static MonsterWalk() { }

	public MonsterWalk(short ID, int x, int y, CatalogyMonster cata) { }

	private void addEff() { }

	public static bool isMonsterPokemon(int idMonster) { }

	public virtual bool isTru() { }

	public virtual void loadInfoAgain(CatalogyMonster cata) { }

	public virtual void paint(mGraphics g) { }

	public void paintFrame(mGraphics g, MainImage img, int actest) { }

	public virtual void update() { }

}

