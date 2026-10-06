namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryWriter
{
	internal Stream sout; //Field offset: 0x10
	internal FormatterTypeStyle formatterTypeStyle; //Field offset: 0x18
	internal Hashtable objectMapTable; //Field offset: 0x20
	internal ObjectWriter objectWriter; //Field offset: 0x28
	internal BinaryWriter dataWriter; //Field offset: 0x30
	internal int m_nestedObjectCount; //Field offset: 0x38
	private int nullCount; //Field offset: 0x3C
	internal BinaryMethodCall binaryMethodCall; //Field offset: 0x40
	internal BinaryMethodReturn binaryMethodReturn; //Field offset: 0x48
	internal BinaryObject binaryObject; //Field offset: 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; //Field offset: 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; //Field offset: 0x60
	internal BinaryObjectString binaryObjectString; //Field offset: 0x68
	internal BinaryArray binaryArray; //Field offset: 0x70
	private Byte[] byteBuffer; //Field offset: 0x78
	private int chunkSize; //Field offset: 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0x90
	internal ObjectNull objectNull; //Field offset: 0x98
	internal MemberReference memberReference; //Field offset: 0xA0
	internal BinaryAssembly binaryAssembly; //Field offset: 0xA8

	internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	private void InternalWriteItemNull() { }

	private void WriteArrayAsBytes(Array array, int typeLength) { }

	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	internal void WriteBegin() { }

	internal void WriteBoolean(bool value) { }

	internal void WriteByte(byte value) { }

	private void WriteBytes(Byte[] value) { }

	private void WriteBytes(Byte[] byteA, int offset, int size) { }

	internal void WriteChar(char value) { }

	internal void WriteChars(Char[] value) { }

	internal void WriteDateTime(DateTime value) { }

	internal void WriteDecimal(decimal value) { }

	internal void WriteDelayedNullItem() { }

	internal void WriteDouble(double value) { }

	internal void WriteEnd() { }

	internal void WriteInt16(short value) { }

	internal void WriteInt32(int value) { }

	internal void WriteInt64(long value) { }

	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteItemEnd() { }

	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	internal void WriteMethodCall() { }

	internal void WriteMethodReturn() { }

	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, String[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Byte[] byteA) { }

	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteObjectString(int objectId, string value) { }

	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Int32[] lengthA, Int32[] lowerBoundA) { }

	internal void WriteSByte(sbyte value) { }

	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	internal void WriteSerializationHeaderEnd() { }

	internal void WriteSingle(float value) { }

	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	internal void WriteString(string value) { }

	internal void WriteTimeSpan(TimeSpan value) { }

	internal void WriteUInt16(ushort value) { }

	internal void WriteUInt32(uint value) { }

	internal void WriteUInt64(ulong value) { }

	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

