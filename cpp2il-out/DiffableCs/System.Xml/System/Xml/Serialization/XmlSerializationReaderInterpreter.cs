namespace System.Xml.Serialization;

internal class XmlSerializationReaderInterpreter : XmlSerializationReader
{
	private class FixupCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		private ClassMap _map; //Field offset: 0x18
		private bool _isValueList; //Field offset: 0x20

		public FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

		public void FixupMembers(object fixup) { }

	}

	private class ReaderCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		public ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

		internal object ReadObject() { }

	}

	private static readonly XmlQualifiedName AnyType; //Field offset: 0x0
	private static readonly Object[] empty_array; //Field offset: 0x8
	private XmlMapping _typeMap; //Field offset: 0xD0
	private SerializationFormat _format; //Field offset: 0xD8

	private static XmlSerializationReaderInterpreter() { }

	public XmlSerializationReaderInterpreter(XmlMapping typeMap) { }

	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	private void CopyEnumerableList(object source, object dest) { }

	private object CreateInstance(Type type) { }

	private static object CreateInstance(Type type, bool nonPublic) { }

	private object CreateList(Type listType) { }

	private void FillList(object list, object items) { }

	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	protected virtual void InitCallbacks() { }

	private object InitializeList(TypeData listType) { }

	protected virtual void InitIDs() { }

	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	protected override void ProcessUnknownAttribute(object target) { }

	protected override void ProcessUnknownElement(object target) { }

	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	protected override object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	protected override void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	protected override object ReadMessage(XmlMembersMapping typeMap) { }

	protected override object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	public object ReadRoot() { }

	private object ReadRoot(XmlTypeMapping rootMap) { }

	private object ReadXmlNode(TypeData type, bool wrapped) { }

	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

}

