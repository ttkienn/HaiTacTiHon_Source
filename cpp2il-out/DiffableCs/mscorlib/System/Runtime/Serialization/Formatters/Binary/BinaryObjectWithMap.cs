namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMap
{
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	internal int objectId; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal int numMembers; //Field offset: 0x20
	internal String[] memberNames; //Field offset: 0x28
	internal int assemId; //Field offset: 0x30

	internal BinaryObjectWithMap() { }

	internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, string name, int numMembers, String[] memberNames, int assemId) { }

	public override void Write(__BinaryWriter sout) { }

}

