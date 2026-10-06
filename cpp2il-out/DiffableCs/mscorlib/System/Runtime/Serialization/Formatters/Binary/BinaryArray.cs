namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryArray
{
	internal int objectId; //Field offset: 0x10
	internal int rank; //Field offset: 0x14
	internal Int32[] lengthA; //Field offset: 0x18
	internal Int32[] lowerBoundA; //Field offset: 0x20
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x28
	internal object typeInformation; //Field offset: 0x30
	internal int assemId; //Field offset: 0x38
	private BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; //Field offset: 0x40

	internal BinaryArray() { }

	internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum) { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, int rank, Int32[] lengthA, Int32[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	public override void Write(__BinaryWriter sout) { }

}

