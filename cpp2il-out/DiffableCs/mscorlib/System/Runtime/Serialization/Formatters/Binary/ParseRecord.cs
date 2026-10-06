namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ParseRecord
{
	internal static int parseRecordIdCount; //Field offset: 0x0
	internal InternalParseTypeE PRparseTypeEnum; //Field offset: 0x10
	internal InternalObjectTypeE PRobjectTypeEnum; //Field offset: 0x14
	internal InternalArrayTypeE PRarrayTypeEnum; //Field offset: 0x18
	internal InternalMemberTypeE PRmemberTypeEnum; //Field offset: 0x1C
	internal InternalMemberValueE PRmemberValueEnum; //Field offset: 0x20
	internal InternalObjectPositionE PRobjectPositionEnum; //Field offset: 0x24
	internal string PRname; //Field offset: 0x28
	internal string PRvalue; //Field offset: 0x30
	internal object PRvarValue; //Field offset: 0x38
	internal string PRkeyDt; //Field offset: 0x40
	internal Type PRdtType; //Field offset: 0x48
	internal InternalPrimitiveTypeE PRdtTypeCode; //Field offset: 0x50
	internal bool PRisEnum; //Field offset: 0x54
	internal long PRobjectId; //Field offset: 0x58
	internal long PRidRef; //Field offset: 0x60
	internal string PRarrayElementTypeString; //Field offset: 0x68
	internal Type PRarrayElementType; //Field offset: 0x70
	internal bool PRisArrayVariant; //Field offset: 0x78
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; //Field offset: 0x7C
	internal int PRrank; //Field offset: 0x80
	internal Int32[] PRlengthA; //Field offset: 0x88
	internal Int32[] PRpositionA; //Field offset: 0x90
	internal Int32[] PRlowerBoundA; //Field offset: 0x98
	internal Int32[] PRupperBoundA; //Field offset: 0xA0
	internal Int32[] PRindexMap; //Field offset: 0xA8
	internal int PRmemberIndex; //Field offset: 0xB0
	internal int PRlinearlength; //Field offset: 0xB4
	internal Int32[] PRrectangularMap; //Field offset: 0xB8
	internal bool PRisLowerBound; //Field offset: 0xC0
	internal long PRtopId; //Field offset: 0xC8
	internal long PRheaderId; //Field offset: 0xD0
	internal ReadObjectInfo PRobjectInfo; //Field offset: 0xD8
	internal bool PRisValueTypeFixup; //Field offset: 0xE0
	internal object PRnewObj; //Field offset: 0xE8
	internal Object[] PRobjectA; //Field offset: 0xF0
	internal PrimitiveArray PRprimitiveArray; //Field offset: 0xF8
	internal bool PRisRegistered; //Field offset: 0x100
	internal Object[] PRmemberData; //Field offset: 0x108
	internal SerializationInfo PRsi; //Field offset: 0x110
	internal int PRnullCount; //Field offset: 0x118

	private static ParseRecord() { }

	internal ParseRecord() { }

	internal void Init() { }

}

