namespace System.Xml.Schema;

internal sealed class XdrBuilder : SchemaBuilder
{
	private sealed class AttributeContent
	{
		internal SchemaAttDef _AttDef; //Field offset: 0x10
		internal XmlQualifiedName _Name; //Field offset: 0x18
		internal string _Prefix; //Field offset: 0x20
		internal bool _Required; //Field offset: 0x28
		internal uint _MinVal; //Field offset: 0x2C
		internal uint _MaxVal; //Field offset: 0x30
		internal uint _MaxLength; //Field offset: 0x34
		internal uint _MinLength; //Field offset: 0x38
		internal bool _EnumerationRequired; //Field offset: 0x3C
		internal bool _HasDataType; //Field offset: 0x3D
		internal bool _Global; //Field offset: 0x3E
		internal object _Default; //Field offset: 0x40

		public AttributeContent() { }

	}

	private sealed class DeclBaseInfo
	{
		internal XmlQualifiedName _Name; //Field offset: 0x10
		internal string _Prefix; //Field offset: 0x18
		internal XmlQualifiedName _TypeName; //Field offset: 0x20
		internal string _TypePrefix; //Field offset: 0x28
		internal object _Default; //Field offset: 0x30
		internal object _Revises; //Field offset: 0x38
		internal uint _MaxOccurs; //Field offset: 0x40
		internal uint _MinOccurs; //Field offset: 0x44
		internal bool _Checking; //Field offset: 0x48
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x50
		internal SchemaAttDef _Attdef; //Field offset: 0x58
		internal DeclBaseInfo _Next; //Field offset: 0x60

		internal DeclBaseInfo() { }

		internal void Reset() { }

	}

	private sealed class ElementContent
	{
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x10
		internal int _ContentAttr; //Field offset: 0x18
		internal int _OrderAttr; //Field offset: 0x1C
		internal bool _MasterGroupRequired; //Field offset: 0x20
		internal bool _ExistTerminal; //Field offset: 0x21
		internal bool _AllowDataType; //Field offset: 0x22
		internal bool _HasDataType; //Field offset: 0x23
		internal bool _HasType; //Field offset: 0x24
		internal bool _EnumerationRequired; //Field offset: 0x25
		internal uint _MinVal; //Field offset: 0x28
		internal uint _MaxVal; //Field offset: 0x2C
		internal uint _MaxLength; //Field offset: 0x30
		internal uint _MinLength; //Field offset: 0x34
		internal Hashtable _AttDefList; //Field offset: 0x38

		public ElementContent() { }

	}

	private sealed class GroupContent
	{
		internal uint _MinVal; //Field offset: 0x10
		internal uint _MaxVal; //Field offset: 0x14
		internal bool _HasMaxAttr; //Field offset: 0x18
		internal bool _HasMinAttr; //Field offset: 0x19
		internal int _Order; //Field offset: 0x1C

		public GroupContent() { }

		internal static GroupContent Copy(GroupContent other) { }

		internal static void Copy(GroupContent from, GroupContent to) { }

	}

	private sealed class XdrAttributeEntry
	{
		internal Token _Attribute; //Field offset: 0x10
		internal int _SchemaFlags; //Field offset: 0x14
		internal XmlSchemaDatatype _Datatype; //Field offset: 0x18
		internal XdrBuildFunction _BuildFunc; //Field offset: 0x20

		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build) { }

	}

	private sealed class XdrBeginChildFunction : MulticastDelegate
	{

		public XdrBeginChildFunction(object object, IntPtr method) { }

		public override void Invoke(XdrBuilder builder) { }

	}

	private sealed class XdrBuildFunction : MulticastDelegate
	{

		public XdrBuildFunction(object object, IntPtr method) { }

		public override void Invoke(XdrBuilder builder, object obj, string prefix) { }

	}

	private sealed class XdrEndChildFunction : MulticastDelegate
	{

		public XdrEndChildFunction(object object, IntPtr method) { }

		public override void Invoke(XdrBuilder builder) { }

	}

	private sealed class XdrEntry
	{
		internal Token _Name; //Field offset: 0x10
		internal Int32[] _NextStates; //Field offset: 0x18
		internal XdrAttributeEntry[] _Attributes; //Field offset: 0x20
		internal XdrInitFunction _InitFunc; //Field offset: 0x28
		internal XdrBeginChildFunction _BeginChildFunc; //Field offset: 0x30
		internal XdrEndChildFunction _EndChildFunc; //Field offset: 0x38
		internal bool _AllowText; //Field offset: 0x40

		internal XdrEntry(Token n, Int32[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText) { }

	}

	private sealed class XdrInitFunction : MulticastDelegate
	{

		public XdrInitFunction(object object, IntPtr method) { }

		public override void Invoke(XdrBuilder builder, object obj) { }

	}

	private static readonly Int32[] S_XDR_Root_Element; //Field offset: 0x0
	private static readonly Int32[] S_XDR_Root_SubElements; //Field offset: 0x8
	private static readonly Int32[] S_XDR_ElementType_SubElements; //Field offset: 0x10
	private static readonly Int32[] S_XDR_AttributeType_SubElements; //Field offset: 0x18
	private static readonly Int32[] S_XDR_Group_SubElements; //Field offset: 0x20
	private static readonly XdrAttributeEntry[] S_XDR_Root_Attributes; //Field offset: 0x28
	private static readonly XdrAttributeEntry[] S_XDR_ElementType_Attributes; //Field offset: 0x30
	private static readonly XdrAttributeEntry[] S_XDR_AttributeType_Attributes; //Field offset: 0x38
	private static readonly XdrAttributeEntry[] S_XDR_Element_Attributes; //Field offset: 0x40
	private static readonly XdrAttributeEntry[] S_XDR_Attribute_Attributes; //Field offset: 0x48
	private static readonly XdrAttributeEntry[] S_XDR_Group_Attributes; //Field offset: 0x50
	private static readonly XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; //Field offset: 0x58
	private static readonly XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; //Field offset: 0x60
	private static readonly XdrEntry[] S_SchemaEntries; //Field offset: 0x68
	private SchemaInfo _SchemaInfo; //Field offset: 0x10
	private string _TargetNamespace; //Field offset: 0x18
	private XmlReader _reader; //Field offset: 0x20
	private PositionInfo positionInfo; //Field offset: 0x28
	private ParticleContentValidator _contentValidator; //Field offset: 0x30
	private XdrEntry _CurState; //Field offset: 0x38
	private XdrEntry _NextState; //Field offset: 0x40
	private HWStack _StateHistory; //Field offset: 0x48
	private HWStack _GroupStack; //Field offset: 0x50
	private string _XdrName; //Field offset: 0x58
	private string _XdrPrefix; //Field offset: 0x60
	private ElementContent _ElementDef; //Field offset: 0x68
	private GroupContent _GroupDef; //Field offset: 0x70
	private AttributeContent _AttributeDef; //Field offset: 0x78
	private DeclBaseInfo _UndefinedAttributeTypes; //Field offset: 0x80
	private DeclBaseInfo _BaseDecl; //Field offset: 0x88
	private XmlNameTable _NameTable; //Field offset: 0x90
	private SchemaNames _SchemaNames; //Field offset: 0x98
	private XmlNamespaceManager _CurNsMgr; //Field offset: 0xA0
	private string _Text; //Field offset: 0xA8
	private ValidationEventHandler validationEventHandler; //Field offset: 0xB0
	private Hashtable _UndeclaredElements; //Field offset: 0xB8
	private XmlResolver xmlResolver; //Field offset: 0xC0

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 19
	}

	private static XdrBuilder() { }

	internal XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	private void AddOrder() { }

	private XmlSchemaDatatype CheckDatatype(string str) { }

	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	internal virtual void EndChildren() { }

	private int GetContent(XmlQualifiedName qname) { }

	private bool GetModel(XmlQualifiedName qname) { }

	private bool GetNextState(XmlQualifiedName qname) { }

	private int GetOrder(XmlQualifiedName qname) { }

	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	internal virtual bool IsContentParsed() { }

	private bool IsGlobal(int flags) { }

	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	private bool IsSkipableElement(XmlQualifiedName qname) { }

	internal static bool IsXdrSchema(string uri) { }

	private static bool IsYes(object obj, XdrBuilder builder) { }

	private bool LoadSchema(string uri) { }

	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	private static bool ParseInteger(string str, ref uint n) { }

	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	private void Pop() { }

	private void PopGroupInfo() { }

	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	internal virtual void ProcessCData(string value) { }

	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	private void Push() { }

	private void PushGroupInfo() { }

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	private void SendValidationEvent(string code) { }

	private void SendValidationEvent(string code, string msg) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	internal virtual void StartChildren() { }

	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	private static void XDR_BeginElementType(XdrBuilder builder) { }

	private static void XDR_BeginRoot(XdrBuilder builder) { }

	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	private static void XDR_EndAttribute(XdrBuilder builder) { }

	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	private static void XDR_EndElement(XdrBuilder builder) { }

	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	private static void XDR_EndElementType(XdrBuilder builder) { }

	private static void XDR_EndGroup(XdrBuilder builder) { }

	private static void XDR_EndRoot(XdrBuilder builder) { }

	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

}

