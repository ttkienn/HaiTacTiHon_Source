namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ValueFixup
{
	internal static MemberInfo valueInfo; //Field offset: 0x0
	internal ValueFixupEnum valueFixupEnum; //Field offset: 0x10
	internal Array arrayObj; //Field offset: 0x18
	internal Int32[] indexMap; //Field offset: 0x20
	internal object header; //Field offset: 0x28
	internal object memberObject; //Field offset: 0x30
	internal ReadObjectInfo objectInfo; //Field offset: 0x38
	internal string memberName; //Field offset: 0x40

	internal ValueFixup(Array arrayObj, Int32[] indexMap) { }

	internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

