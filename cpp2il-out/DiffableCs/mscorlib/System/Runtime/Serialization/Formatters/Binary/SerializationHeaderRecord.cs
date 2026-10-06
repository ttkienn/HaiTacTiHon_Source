namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerializationHeaderRecord
{
	internal int binaryFormatterMajorVersion; //Field offset: 0x10
	internal int binaryFormatterMinorVersion; //Field offset: 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x18
	internal int topId; //Field offset: 0x1C
	internal int headerId; //Field offset: 0x20
	internal int majorVersion; //Field offset: 0x24
	internal int minorVersion; //Field offset: 0x28

	internal SerializationHeaderRecord() { }

	internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	public void Dump() { }

	private static int GetInt32(Byte[] buffer, int index) { }

	public override void Read(__BinaryParser input) { }

	public override void Write(__BinaryWriter sout) { }

}

