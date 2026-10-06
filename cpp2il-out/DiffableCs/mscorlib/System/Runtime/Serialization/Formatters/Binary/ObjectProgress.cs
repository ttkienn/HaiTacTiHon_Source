namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectProgress
{
	internal static int opRecordIdCount; //Field offset: 0x0
	internal bool isInitial; //Field offset: 0x10
	internal int count; //Field offset: 0x14
	internal BinaryTypeEnum expectedType; //Field offset: 0x18
	internal object expectedTypeInformation; //Field offset: 0x20
	internal string name; //Field offset: 0x28
	internal InternalObjectTypeE objectTypeEnum; //Field offset: 0x30
	internal InternalMemberTypeE memberTypeEnum; //Field offset: 0x34
	internal InternalMemberValueE memberValueEnum; //Field offset: 0x38
	internal Type dtType; //Field offset: 0x40
	internal int numItems; //Field offset: 0x48
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x4C
	internal object typeInformation; //Field offset: 0x50
	internal int nullCount; //Field offset: 0x58
	internal int memberLength; //Field offset: 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x60
	internal Object[] typeInformationA; //Field offset: 0x68
	internal String[] memberNames; //Field offset: 0x70
	internal Type[] memberTypes; //Field offset: 0x78
	internal ParseRecord pr; //Field offset: 0x80

	private static ObjectProgress() { }

	internal ObjectProgress() { }

	internal void ArrayCountIncrement(int value) { }

	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	internal void Init() { }

}

