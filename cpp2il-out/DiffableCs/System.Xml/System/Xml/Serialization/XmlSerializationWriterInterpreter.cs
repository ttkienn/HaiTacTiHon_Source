namespace System.Xml.Serialization;

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter
{
	private class CallbackInfo
	{
		private XmlSerializationWriterInterpreter _swi; //Field offset: 0x10
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		public CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

		internal void WriteEnum(object ob) { }

		internal void WriteObject(object ob) { }

	}

	private XmlMapping _typeMap; //Field offset: 0x48
	private SerializationFormat _format; //Field offset: 0x50

	public XmlSerializationWriterInterpreter(XmlMapping typeMap) { }

	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

	private int GetListCount(TypeData listType, object ob) { }

	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	internal static object ImplicitConvert(object obj, Type type) { }

	protected virtual void InitCallbacks() { }

	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	protected override void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	protected override void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	protected override void WriteMessage(XmlMembersMapping membersMap, Object[] parameters) { }

	protected override void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	protected override void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	protected override void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	protected override void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	protected override void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	public void WriteRoot(object ob) { }

}

