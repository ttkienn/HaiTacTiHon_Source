//Type is in global namespace

public class InfoArchi
{
	public static sbyte REWARD_OFF; //Field offset: 0x0
	public static sbyte REWARD_DOING; //Field offset: 0x1
	public static sbyte REWARD_READY; //Field offset: 0x2
	public static sbyte REWARD_GOT; //Field offset: 0x3
	public string name; //Field offset: 0x10
	public string info; //Field offset: 0x18
	public int valueMax; //Field offset: 0x20
	public int valueCur; //Field offset: 0x24
	public int maxLechInfo; //Field offset: 0x28
	public short idIcon; //Field offset: 0x2C
	public sbyte typeReward; //Field offset: 0x2E

	private static InfoArchi() { }

	public InfoArchi(string name, string info, int valueCur, int valueMax, short idIcon, sbyte typeReward) { }

	public InfoArchi() { }

}

