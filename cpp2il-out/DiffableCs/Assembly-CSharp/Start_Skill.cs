//Type is in global namespace

public class Start_Skill
{
	public MainObject objFire; //Field offset: 0x10
	public MainObject objBefire; //Field offset: 0x18
	public mVector vecObjBeFire; //Field offset: 0x20
	public MainSkill skill; //Field offset: 0x28
	public bool isRemove; //Field offset: 0x30
	private bool isVeryFar; //Field offset: 0x31
	private int indexMove; //Field offset: 0x34

	public Start_Skill(MainObject objMain, mVector vec, MainSkill skill) { }

	public void beginSkill() { }

	public void InviMove() { }

	public void movePlayer(int distant, int toX, int toY) { }

	public bool setGoc(int gocCur) { }

	public void setMonsterMoveFire() { }

	public void setMoveFire() { }

}

