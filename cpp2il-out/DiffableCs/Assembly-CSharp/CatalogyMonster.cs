//Type is in global namespace

public class CatalogyMonster
{
	public const sbyte MON_NOR = 0; //Field offset: 0x0
	public const sbyte MON_HUMAN = 1; //Field offset: 0x0
	public int idCat; //Field offset: 0x10
	public int lv; //Field offset: 0x14
	public int maxHp; //Field offset: 0x18
	public sbyte typeMove; //Field offset: 0x1C
	public sbyte isHumanPart; //Field offset: 0x1D
	public sbyte typeMonster; //Field offset: 0x1E
	public short head; //Field offset: 0x20
	public short hair; //Field offset: 0x22
	public short hOne; //Field offset: 0x24
	public short idIcon; //Field offset: 0x26
	public Int16[] mWearing; //Field offset: 0x28
	public string name; //Field offset: 0x30
	public bool isTemplate; //Field offset: 0x38
	public long timeRequest; //Field offset: 0x40

	public CatalogyMonster(int id) { }

	public CatalogyMonster(int id, int lv, int maxHp, sbyte typeMove, string name, sbyte ishuman, short hOne, sbyte typeMonster) { }

	public void addData(short head, short hair, Int16[] wearing) { }

	public static void LoadDataMon(DataInputStream iss, bool isSave) { }

	public static void LoadDataMonTemplate(DataInputStream iss) { }

}

