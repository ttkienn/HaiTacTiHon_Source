namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryParser
{
	private static Encoding encoding; //Field offset: 0x0
	internal static MessageEnd messageEnd; //Field offset: 0x8
	internal ObjectReader objectReader; //Field offset: 0x10
	internal Stream input; //Field offset: 0x18
	internal long topId; //Field offset: 0x20
	internal long headerId; //Field offset: 0x28
	internal SizedArray objectMapIdTable; //Field offset: 0x30
	internal SizedArray assemIdToAssemblyTable; //Field offset: 0x38
	internal SerStack stack; //Field offset: 0x40
	internal BinaryTypeEnum expectedType; //Field offset: 0x48
	internal object expectedTypeInformation; //Field offset: 0x50
	internal ParseRecord PRS; //Field offset: 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; //Field offset: 0x60
	private BinaryReader dataReader; //Field offset: 0x68
	private SerStack opPool; //Field offset: 0x70
	private BinaryObject binaryObject; //Field offset: 0x78
	private BinaryObjectWithMap bowm; //Field offset: 0x80
	private BinaryObjectWithMapTyped bowmt; //Field offset: 0x88
	internal BinaryObjectString objectString; //Field offset: 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; //Field offset: 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0xA0
	private Byte[] byteBuffer; //Field offset: 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0xB0
	internal MemberReference memberReference; //Field offset: 0xB8
	internal ObjectNull objectNull; //Field offset: 0xC0

	internal SizedArray AssemIdToAssemblyTable
	{
		internal get { } //Length: 111
	}

	internal SizedArray ObjectMapIdTable
	{
		internal get { } //Length: 105
	}

	internal ParseRecord prs
	{
		internal get { } //Length: 105
	}

	internal BinaryAssemblyInfo SystemAssemblyInfo
	{
		internal get { } //Length: 222
	}

	private static __BinaryParser() { }

	internal __BinaryParser(Stream stream, ObjectReader objectReader) { }

	internal SizedArray get_AssemIdToAssemblyTable() { }

	internal SizedArray get_ObjectMapIdTable() { }

	internal ParseRecord get_prs() { }

	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	private ObjectProgress GetOp() { }

	private void PutOp(ObjectProgress op) { }

	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadArrayAsBytes(ParseRecord pr) { }

	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void ReadBegin() { }

	internal bool ReadBoolean() { }

	internal byte ReadByte() { }

	internal void ReadBytes(Byte[] byteA, int offset, int size) { }

	internal Byte[] ReadBytes(int length) { }

	internal char ReadChar() { }

	internal Char[] ReadChars(int length) { }

	internal void ReadCrossAppDomainMap() { }

	internal DateTime ReadDateTime() { }

	internal decimal ReadDecimal() { }

	internal double ReadDouble() { }

	internal void ReadEnd() { }

	internal short ReadInt16() { }

	internal int ReadInt32() { }

	internal long ReadInt64() { }

	private void ReadMemberPrimitiveTyped() { }

	private void ReadMemberPrimitiveUnTyped() { }

	private void ReadMemberReference() { }

	private void ReadMessageEnd() { }

	private void ReadObject() { }

	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	internal sbyte ReadSByte() { }

	internal void ReadSerializationHeaderRecord() { }

	internal float ReadSingle() { }

	internal string ReadString() { }

	internal TimeSpan ReadTimeSpan() { }

	internal ushort ReadUInt16() { }

	internal uint ReadUInt32() { }

	internal ulong ReadUInt64() { }

	internal object ReadValue(InternalPrimitiveTypeE code) { }

	internal void Run() { }

}

