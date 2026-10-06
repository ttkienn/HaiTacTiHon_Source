//Type is in global namespace

public class MainPlayer : MainObject
{
	public static Int16[][][] mPosTrainOther; //Field offset: 0x0
	public int timeStand; //Field offset: 0x468
	public int timeFireMapTrain; //Field offset: 0x46C
	public int indexSkillFireMapTrain; //Field offset: 0x470
	public int countAutoMove; //Field offset: 0x474
	public int xStopMove; //Field offset: 0x478
	public int yStopMove; //Field offset: 0x47C
	public mVector vecAllInfo; //Field offset: 0x480
	public mVector vecAllInfoParty; //Field offset: 0x488
	public int maxTimeUpsea; //Field offset: 0x490

	private static MainPlayer() { }

	public MainPlayer() { }

	public virtual void addSkillFire(MainSkill skill, mVector vec) { }

	public void checkRemoveBoat() { }

	public virtual iCommand getCenterCmd() { }

	public virtual void resetAction() { }

	public virtual void setActionSea(sbyte type, int xSea, int ySea) { }

	public void setAutoMoveNear() { }

	public virtual void setDataBeginSkill(MainSkill skill, mVector vec) { }

	public void setMove(bool isAutomove) { }

	private void setMoveSea(MainObject objMain) { }

	public virtual void setNextSea() { }

	public override void setPosDownBoat() { }

	public override void setPosUpBoat() { }

	public override void setXtoYto(int xto, int yto) { }

	public virtual void updateActionDown() { }

	public virtual void updateActionDown_2() { }

	public virtual void updateActionUp() { }

	public virtual void updateActionUp_2() { }

	public virtual void updateActionUpBoat() { }

	public override void updateMapTrain() { }

}

