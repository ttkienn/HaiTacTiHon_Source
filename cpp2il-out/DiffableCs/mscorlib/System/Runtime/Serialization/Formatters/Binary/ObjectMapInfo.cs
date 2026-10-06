namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMapInfo
{
	internal int objectId; //Field offset: 0x10
	private int numMembers; //Field offset: 0x14
	private String[] memberNames; //Field offset: 0x18
	private Type[] memberTypes; //Field offset: 0x20

	internal ObjectMapInfo(int objectId, int numMembers, String[] memberNames, Type[] memberTypes) { }

	internal bool isCompatible(int numMembers, String[] memberNames, Type[] memberTypes) { }

}

