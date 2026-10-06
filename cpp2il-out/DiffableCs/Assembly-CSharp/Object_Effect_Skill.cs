//Type is in global namespace

public class Object_Effect_Skill
{
	public short ID; //Field offset: 0x10
	public sbyte tem; //Field offset: 0x12
	public int hpShow; //Field offset: 0x14
	public int hpLast; //Field offset: 0x18
	public int hpPlus; //Field offset: 0x1C
	public int hpMagic; //Field offset: 0x20
	public Int32[] mEffTypePlus; //Field offset: 0x28
	public Int32[] mEff_HP_Plus; //Field offset: 0x30
	public Int32[] mEff_Time_Plus; //Field offset: 0x38
	public MainSkill skillMonster; //Field offset: 0x40

	public Object_Effect_Skill(short Id, sbyte tem) { }

	public Object_Effect_Skill(short Id, sbyte tem, MainSkill skill) { }

	public void setHP(int hpShow, int hpLast, int hpMagic) { }

}

