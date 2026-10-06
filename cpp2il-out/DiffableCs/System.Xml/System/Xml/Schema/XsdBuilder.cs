namespace System.Xml.Schema;

internal sealed class XsdBuilder : SchemaBuilder
{
	private class BuilderNamespaceManager : XmlNamespaceManager
	{
		private XmlNamespaceManager nsMgr; //Field offset: 0x50
		private XmlReader reader; //Field offset: 0x58

		public BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader) { }

		public virtual string LookupNamespace(string prefix) { }

	}

	private enum State
	{
		Root = 0,
		Schema = 1,
		Annotation = 2,
		Include = 3,
		Import = 4,
		Element = 5,
		Attribute = 6,
		AttributeGroup = 7,
		AttributeGroupRef = 8,
		AnyAttribute = 9,
		Group = 10,
		GroupRef = 11,
		All = 12,
		Choice = 13,
		Sequence = 14,
		Any = 15,
		Notation = 16,
		SimpleType = 17,
		ComplexType = 18,
		ComplexContent = 19,
		ComplexContentRestriction = 20,
		ComplexContentExtension = 21,
		SimpleContent = 22,
		SimpleContentExtension = 23,
		SimpleContentRestriction = 24,
		SimpleTypeUnion = 25,
		SimpleTypeList = 26,
		SimpleTypeRestriction = 27,
		Unique = 28,
		Key = 29,
		KeyRef = 30,
		Selector = 31,
		Field = 32,
		MinExclusive = 33,
		MinInclusive = 34,
		MaxExclusive = 35,
		MaxInclusive = 36,
		TotalDigits = 37,
		FractionDigits = 38,
		Length = 39,
		MinLength = 40,
		MaxLength = 41,
		Enumeration = 42,
		Pattern = 43,
		WhiteSpace = 44,
		AppInfo = 45,
		Documentation = 46,
		Redefine = 47,
	}

	private sealed class XsdAttributeEntry
	{
		public Token Attribute; //Field offset: 0x10
		public XsdBuildFunction BuildFunc; //Field offset: 0x18

		public XsdAttributeEntry(Token a, XsdBuildFunction build) { }

	}

	private sealed class XsdBuildFunction : MulticastDelegate
	{

		public XsdBuildFunction(object object, IntPtr method) { }

		public override void Invoke(XsdBuilder builder, string value) { }

	}

	private sealed class XsdEndChildFunction : MulticastDelegate
	{

		public XsdEndChildFunction(object object, IntPtr method) { }

		public override void Invoke(XsdBuilder builder) { }

	}

	private sealed class XsdEntry
	{
		public Token Name; //Field offset: 0x10
		public State CurrentState; //Field offset: 0x14
		public State[] NextStates; //Field offset: 0x18
		public XsdAttributeEntry[] Attributes; //Field offset: 0x20
		public XsdInitFunction InitFunc; //Field offset: 0x28
		public XsdEndChildFunction EndChildFunc; //Field offset: 0x30
		public bool ParseContent; //Field offset: 0x38

		public XsdEntry(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

	}

	private sealed class XsdInitFunction : MulticastDelegate
	{

		public XsdInitFunction(object object, IntPtr method) { }

		public override void Invoke(XsdBuilder builder, string value) { }

	}

	private static readonly State[] SchemaElement; //Field offset: 0x0
	private static readonly State[] SchemaSubelements; //Field offset: 0x8
	private static readonly State[] AttributeSubelements; //Field offset: 0x10
	private static readonly State[] ElementSubelements; //Field offset: 0x18
	private static readonly State[] ComplexTypeSubelements; //Field offset: 0x20
	private static readonly State[] SimpleContentSubelements; //Field offset: 0x28
	private static readonly State[] SimpleContentExtensionSubelements; //Field offset: 0x30
	private static readonly State[] SimpleContentRestrictionSubelements; //Field offset: 0x38
	private static readonly State[] ComplexContentSubelements; //Field offset: 0x40
	private static readonly State[] ComplexContentExtensionSubelements; //Field offset: 0x48
	private static readonly State[] ComplexContentRestrictionSubelements; //Field offset: 0x50
	private static readonly State[] SimpleTypeSubelements; //Field offset: 0x58
	private static readonly State[] SimpleTypeRestrictionSubelements; //Field offset: 0x60
	private static readonly State[] SimpleTypeListSubelements; //Field offset: 0x68
	private static readonly State[] SimpleTypeUnionSubelements; //Field offset: 0x70
	private static readonly State[] RedefineSubelements; //Field offset: 0x78
	private static readonly State[] AttributeGroupSubelements; //Field offset: 0x80
	private static readonly State[] GroupSubelements; //Field offset: 0x88
	private static readonly State[] AllSubelements; //Field offset: 0x90
	private static readonly State[] ChoiceSequenceSubelements; //Field offset: 0x98
	private static readonly State[] IdentityConstraintSubelements; //Field offset: 0xA0
	private static readonly State[] AnnotationSubelements; //Field offset: 0xA8
	private static readonly State[] AnnotatedSubelements; //Field offset: 0xB0
	private static readonly XsdAttributeEntry[] SchemaAttributes; //Field offset: 0xB8
	private static readonly XsdAttributeEntry[] AttributeAttributes; //Field offset: 0xC0
	private static readonly XsdAttributeEntry[] ElementAttributes; //Field offset: 0xC8
	private static readonly XsdAttributeEntry[] ComplexTypeAttributes; //Field offset: 0xD0
	private static readonly XsdAttributeEntry[] SimpleContentAttributes; //Field offset: 0xD8
	private static readonly XsdAttributeEntry[] SimpleContentExtensionAttributes; //Field offset: 0xE0
	private static readonly XsdAttributeEntry[] SimpleContentRestrictionAttributes; //Field offset: 0xE8
	private static readonly XsdAttributeEntry[] ComplexContentAttributes; //Field offset: 0xF0
	private static readonly XsdAttributeEntry[] ComplexContentExtensionAttributes; //Field offset: 0xF8
	private static readonly XsdAttributeEntry[] ComplexContentRestrictionAttributes; //Field offset: 0x100
	private static readonly XsdAttributeEntry[] SimpleTypeAttributes; //Field offset: 0x108
	private static readonly XsdAttributeEntry[] SimpleTypeRestrictionAttributes; //Field offset: 0x110
	private static readonly XsdAttributeEntry[] SimpleTypeUnionAttributes; //Field offset: 0x118
	private static readonly XsdAttributeEntry[] SimpleTypeListAttributes; //Field offset: 0x120
	private static readonly XsdAttributeEntry[] AttributeGroupAttributes; //Field offset: 0x128
	private static readonly XsdAttributeEntry[] AttributeGroupRefAttributes; //Field offset: 0x130
	private static readonly XsdAttributeEntry[] GroupAttributes; //Field offset: 0x138
	private static readonly XsdAttributeEntry[] GroupRefAttributes; //Field offset: 0x140
	private static readonly XsdAttributeEntry[] ParticleAttributes; //Field offset: 0x148
	private static readonly XsdAttributeEntry[] AnyAttributes; //Field offset: 0x150
	private static readonly XsdAttributeEntry[] IdentityConstraintAttributes; //Field offset: 0x158
	private static readonly XsdAttributeEntry[] SelectorAttributes; //Field offset: 0x160
	private static readonly XsdAttributeEntry[] FieldAttributes; //Field offset: 0x168
	private static readonly XsdAttributeEntry[] NotationAttributes; //Field offset: 0x170
	private static readonly XsdAttributeEntry[] IncludeAttributes; //Field offset: 0x178
	private static readonly XsdAttributeEntry[] ImportAttributes; //Field offset: 0x180
	private static readonly XsdAttributeEntry[] FacetAttributes; //Field offset: 0x188
	private static readonly XsdAttributeEntry[] AnyAttributeAttributes; //Field offset: 0x190
	private static readonly XsdAttributeEntry[] DocumentationAttributes; //Field offset: 0x198
	private static readonly XsdAttributeEntry[] AppinfoAttributes; //Field offset: 0x1A0
	private static readonly XsdAttributeEntry[] RedefineAttributes; //Field offset: 0x1A8
	private static readonly XsdAttributeEntry[] AnnotationAttributes; //Field offset: 0x1B0
	private static readonly XsdEntry[] SchemaEntries; //Field offset: 0x1B8
	private static readonly Int32[] DerivationMethodValues; //Field offset: 0x1C0
	private static readonly String[] DerivationMethodStrings; //Field offset: 0x1C8
	private static readonly String[] FormStringValues; //Field offset: 0x1D0
	private static readonly String[] UseStringValues; //Field offset: 0x1D8
	private static readonly String[] ProcessContentsStringValues; //Field offset: 0x1E0
	private XmlReader reader; //Field offset: 0x10
	private PositionInfo positionInfo; //Field offset: 0x18
	private XsdEntry currentEntry; //Field offset: 0x20
	private XsdEntry nextEntry; //Field offset: 0x28
	private bool hasChild; //Field offset: 0x30
	private HWStack stateHistory; //Field offset: 0x38
	private Stack containerStack; //Field offset: 0x40
	private XmlNameTable nameTable; //Field offset: 0x48
	private SchemaNames schemaNames; //Field offset: 0x50
	private XmlNamespaceManager namespaceManager; //Field offset: 0x58
	private bool canIncludeImport; //Field offset: 0x60
	private XmlSchema schema; //Field offset: 0x68
	private XmlSchemaObject xso; //Field offset: 0x70
	private XmlSchemaElement element; //Field offset: 0x78
	private XmlSchemaAny anyElement; //Field offset: 0x80
	private XmlSchemaAttribute attribute; //Field offset: 0x88
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x90
	private XmlSchemaComplexType complexType; //Field offset: 0x98
	private XmlSchemaSimpleType simpleType; //Field offset: 0xA0
	private XmlSchemaComplexContent complexContent; //Field offset: 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; //Field offset: 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; //Field offset: 0xB8
	private XmlSchemaSimpleContent simpleContent; //Field offset: 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; //Field offset: 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; //Field offset: 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; //Field offset: 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; //Field offset: 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; //Field offset: 0xE8
	private XmlSchemaGroup group; //Field offset: 0xF0
	private XmlSchemaGroupRef groupRef; //Field offset: 0xF8
	private XmlSchemaAll all; //Field offset: 0x100
	private XmlSchemaChoice choice; //Field offset: 0x108
	private XmlSchemaSequence sequence; //Field offset: 0x110
	private XmlSchemaParticle particle; //Field offset: 0x118
	private XmlSchemaAttributeGroup attributeGroup; //Field offset: 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; //Field offset: 0x128
	private XmlSchemaNotation notation; //Field offset: 0x130
	private XmlSchemaIdentityConstraint identityConstraint; //Field offset: 0x138
	private XmlSchemaXPath xpath; //Field offset: 0x140
	private XmlSchemaInclude include; //Field offset: 0x148
	private XmlSchemaImport import; //Field offset: 0x150
	private XmlSchemaAnnotation annotation; //Field offset: 0x158
	private XmlSchemaAppInfo appInfo; //Field offset: 0x160
	private XmlSchemaDocumentation documentation; //Field offset: 0x168
	private XmlSchemaFacet facet; //Field offset: 0x170
	private XmlNode[] markup; //Field offset: 0x178
	private XmlSchemaRedefine redefine; //Field offset: 0x180
	private ValidationEventHandler validationEventHandler; //Field offset: 0x188
	private ArrayList unhandledAttributes; //Field offset: 0x190
	private Hashtable namespaces; //Field offset: 0x198

	private Token CurrentElement
	{
		private get { } //Length: 26
	}

	private XmlSchemaObject ParentContainer
	{
		private get { } //Length: 139
	}

	private Token ParentElement
	{
		private get { } //Length: 124
	}

	private static XsdBuilder() { }

	internal XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	private void AddAttribute(XmlSchemaObject value) { }

	private void AddParticle(XmlSchemaParticle particle) { }

	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	private static void EndAppinfo(XsdBuilder builder) { }

	internal virtual void EndChildren() { }

	private static void EndDocumentation(XsdBuilder builder) { }

	private static void EndRedefine(XsdBuilder builder) { }

	private Token get_CurrentElement() { }

	private XmlSchemaObject get_ParentContainer() { }

	private Token get_ParentElement() { }

	private XmlSchemaObject GetContainer(State state) { }

	private bool GetNextState(XmlQualifiedName qname) { }

	private static void InitAll(XsdBuilder builder, string value) { }

	private static void InitAnnotation(XsdBuilder builder, string value) { }

	private static void InitAny(XsdBuilder builder, string value) { }

	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	private static void InitAppinfo(XsdBuilder builder, string value) { }

	private static void InitAttribute(XsdBuilder builder, string value) { }

	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	private static void InitChoice(XsdBuilder builder, string value) { }

	private static void InitComplexContent(XsdBuilder builder, string value) { }

	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	private static void InitComplexType(XsdBuilder builder, string value) { }

	private static void InitDocumentation(XsdBuilder builder, string value) { }

	private static void InitElement(XsdBuilder builder, string value) { }

	private static void InitFacet(XsdBuilder builder, string value) { }

	private static void InitField(XsdBuilder builder, string value) { }

	private static void InitGroup(XsdBuilder builder, string value) { }

	private static void InitGroupRef(XsdBuilder builder, string value) { }

	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	private static void InitImport(XsdBuilder builder, string value) { }

	private static void InitInclude(XsdBuilder builder, string value) { }

	private static void InitNotation(XsdBuilder builder, string value) { }

	private static void InitRedefine(XsdBuilder builder, string value) { }

	private static void InitSchema(XsdBuilder builder, string value) { }

	private static void InitSelector(XsdBuilder builder, string value) { }

	private static void InitSequence(XsdBuilder builder, string value) { }

	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	private static void InitSimpleType(XsdBuilder builder, string value) { }

	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	internal virtual bool IsContentParsed() { }

	private bool IsSkipableElement(XmlQualifiedName qname) { }

	private int ParseBlockFinalEnum(string value, string attributeName) { }

	private bool ParseBoolean(string value, string attributeName) { }

	private int ParseEnum(string value, string attributeName, String[] values) { }

	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	private static string ParseUriReference(string s) { }

	private void Pop() { }

	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	internal virtual void ProcessCData(string value) { }

	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	private void Push() { }

	private void RecordPosition() { }

	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	private void SendValidationEvent(string code, string msg) { }

	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	private void SendValidationEvent(XmlSchemaException e) { }

	private void SetContainer(State state, object container) { }

	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	internal virtual void StartChildren() { }

}

