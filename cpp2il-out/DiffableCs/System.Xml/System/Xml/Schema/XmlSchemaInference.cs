namespace System.Xml.Schema;

public sealed class XmlSchemaInference
{
	internal enum InferenceOption
	{
		Restricted = 0,
		Relaxed = 1,
	}

	internal static XmlQualifiedName ST_boolean; //Field offset: 0x0
	internal static XmlQualifiedName ST_byte; //Field offset: 0x8
	internal static XmlQualifiedName ST_unsignedByte; //Field offset: 0x10
	internal static XmlQualifiedName ST_short; //Field offset: 0x18
	internal static XmlQualifiedName ST_unsignedShort; //Field offset: 0x20
	internal static XmlQualifiedName ST_int; //Field offset: 0x28
	internal static XmlQualifiedName ST_unsignedInt; //Field offset: 0x30
	internal static XmlQualifiedName ST_long; //Field offset: 0x38
	internal static XmlQualifiedName ST_unsignedLong; //Field offset: 0x40
	internal static XmlQualifiedName ST_integer; //Field offset: 0x48
	internal static XmlQualifiedName ST_decimal; //Field offset: 0x50
	internal static XmlQualifiedName ST_float; //Field offset: 0x58
	internal static XmlQualifiedName ST_double; //Field offset: 0x60
	internal static XmlQualifiedName ST_duration; //Field offset: 0x68
	internal static XmlQualifiedName ST_dateTime; //Field offset: 0x70
	internal static XmlQualifiedName ST_time; //Field offset: 0x78
	internal static XmlQualifiedName ST_date; //Field offset: 0x80
	internal static XmlQualifiedName ST_gYearMonth; //Field offset: 0x88
	internal static XmlQualifiedName ST_string; //Field offset: 0x90
	internal static XmlQualifiedName ST_anySimpleType; //Field offset: 0x98
	internal static XmlQualifiedName[] SimpleTypes; //Field offset: 0xA0
	private XmlSchema rootSchema; //Field offset: 0x10
	private XmlSchemaSet schemaSet; //Field offset: 0x18
	private XmlReader xtr; //Field offset: 0x20
	private NameTable nametable; //Field offset: 0x28
	private string TargetNamespace; //Field offset: 0x30
	private XmlNamespaceManager NamespaceManager; //Field offset: 0x38
	private ArrayList schemaList; //Field offset: 0x40
	private InferenceOption occurrence; //Field offset: 0x48
	private InferenceOption typeInference; //Field offset: 0x4C

	public InferenceOption Occurrence
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public InferenceOption TypeInference
	{
		 set { } //Length: 351
	}

	private static XmlSchemaInference() { }

	public XmlSchemaInference() { }

	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	private XmlSchema CreateXmlSchema(string targetNS) { }

	internal static int DateTime(string s, bool bDate, bool bTime) { }

	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	public InferenceOption get_Occurrence() { }

	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	private static int GetSchemaType(XmlQualifiedName qname) { }

	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	public void set_Occurrence(InferenceOption value) { }

	public void set_TypeInference(InferenceOption value) { }

	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

}

