//Type is in global namespace

public class Pet : MainMonster
{
	public static Int32[][] mChoper; //Field offset: 0x0
	public const sbyte PET_CHOPPER = 0; //Field offset: 0x0
	public const sbyte PET_TOTO = 1; //Field offset: 0x0
	public const sbyte PET_LASSO = 2; //Field offset: 0x0
	public const sbyte PET_GHOST = 3; //Field offset: 0x0
	public const sbyte PET_BAT = 4; //Field offset: 0x0
	public const sbyte PET_GHOST_BROOK = 5; //Field offset: 0x0
	public static Int32[][] mLasso; //Field offset: 0x8
	public static Int32[][] mGhost; //Field offset: 0x10
	public static Int32[][] mBat; //Field offset: 0x18
	public static Int32[][] mDog; //Field offset: 0x20
	public static Int32[] mPlayStandChopper; //Field offset: 0x28
	public static Int32[] mPlayStandDogVip; //Field offset: 0x30
	private MainImage img; //Field offset: 0x4D0

	private static Pet() { }

	public Pet(short ID, short idMain, short idImage, sbyte type) { }

	public virtual void paint(mGraphics g) { }

	public void setBeginMove() { }

	public virtual void setDataPet(short ID, short idImage, sbyte type) { }

	public void setInfoObjMain() { }

	public virtual void setPetActionFire() { }

	public virtual void update() { }

}

