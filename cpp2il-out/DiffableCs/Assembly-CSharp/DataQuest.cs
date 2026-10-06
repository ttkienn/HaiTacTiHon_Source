//Type is in global namespace

public class DataQuest
{
	public const sbyte Q_GET_ITEM = 2; //Field offset: 0x0
	public const sbyte Q_KILL_MONSTER = 1; //Field offset: 0x0
	public const sbyte Q_TRANPORTER = 3; //Field offset: 0x0
	public const sbyte Q_TALK = 0; //Field offset: 0x0
	public static String[] nameItemQuest; //Field offset: 0x0
	public sbyte typeQuest; //Field offset: 0x10
	public short IDItem; //Field offset: 0x12
	public short numMax; //Field offset: 0x14
	public short numCur; //Field offset: 0x16
	public string nameItem; //Field offset: 0x18

	private static DataQuest() { }

	public DataQuest(sbyte typeQ) { }

	public void loadNameAgain() { }

	public void SetDataQuest(short ID, short numM, short numC) { }

}

