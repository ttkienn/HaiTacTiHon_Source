//Type is in global namespace

public class TabSkill : MainTab
{
	public static iCommand cmdSetPoint; //Field offset: 0x0
	public static iCommand cmdSetHotKey; //Field offset: 0x8
	public static int numVecListSkillPaint; //Field offset: 0x10
	public static int indexDevil; //Field offset: 0x14
	public static int indexBuff; //Field offset: 0x18
	public static int indexPassive; //Field offset: 0x1C
	public static int indexHaki; //Field offset: 0x20
	public static int indexJob; //Field offset: 0x24
	public static int indexDevilSkill; //Field offset: 0x28
	public static int indexBuffSkill; //Field offset: 0x2C
	public static int indexPassiveSkill; //Field offset: 0x30
	public static int indexHakiSkill; //Field offset: 0x34
	public static int indexJobSkill; //Field offset: 0x38
	public static int numActiveSkill; //Field offset: 0x3C
	public static int numDevilSkill; //Field offset: 0x40
	public static int numBuffSkill; //Field offset: 0x44
	public static int numPassiveSkill; //Field offset: 0x48
	public static int numHakiSkill; //Field offset: 0x4C
	public static int numJobSkill; //Field offset: 0x50
	public static mVector vecListSkillPaint; //Field offset: 0x58
	private Skill_Info skillCur; //Field offset: 0x88
	private mVector vecCmd; //Field offset: 0x90
	private InputDialog input; //Field offset: 0x98
	private ListNew list; //Field offset: 0xA0
	private MarqueeText marName; //Field offset: 0xA8
	private Scroll scrSkill; //Field offset: 0xB0

	private static TabSkill() { }

	public TabSkill(string name) { }

	public virtual void beginFocus() { }

	public int changeValue(int value) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void getSkillCur() { }

	private void initCmd() { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g) { }

	public void setClip(mGraphics g) { }

	public void setPosCmd(mVector vec) { }

	public virtual void setPosInfo() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

