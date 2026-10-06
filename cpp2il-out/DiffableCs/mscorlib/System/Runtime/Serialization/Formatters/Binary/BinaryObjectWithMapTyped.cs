namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMapTyped
{
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	internal int objectId; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal int numMembers; //Field offset: 0x20
	internal String[] memberNames; //Field offset: 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x30
	internal Object[] typeInformationA; //Field offset: 0x38
	internal Int32[] memberAssemIds; //Field offset: 0x40
	internal int assemId; //Field offset: 0x48

	internal BinaryObjectWithMapTyped() { }

	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, string name, int numMembers, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, int assemId) { }

	public override void Write(__BinaryWriter sout) { }

}

