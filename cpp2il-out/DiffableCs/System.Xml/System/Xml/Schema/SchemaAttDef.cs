namespace System.Xml.Schema;

internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
{
	public enum Reserve
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
	}

	public static readonly SchemaAttDef Empty; //Field offset: 0x0
	private string defExpanded; //Field offset: 0x60
	private int lineNum; //Field offset: 0x68
	private int linePos; //Field offset: 0x6C
	private int valueLineNum; //Field offset: 0x70
	private int valueLinePos; //Field offset: 0x74
	private Reserve reserved; //Field offset: 0x78
	private bool defaultValueChecked; //Field offset: 0x7C
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x80

	internal bool DefaultValueChecked
	{
		internal get { } //Length: 5
	}

	internal string DefaultValueExpanded
	{
		internal get { } //Length: 77
		internal set { } //Length: 13
	}

	internal int LineNumber
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal int LinePosition
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal Reserve Reserved
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal XmlSchemaAttribute SchemaAttribute
	{
		internal get { } //Length: 8
		internal set { } //Length: 16
	}

	private override bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
	{
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdAttributeInfo.IsNonCDataType
	{
		private get { } //Length: 47
	}

	private override bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
	{
		private get { } //Length: 8
	}

	private override int System.Xml.IDtdAttributeInfo.LineNumber
	{
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdAttributeInfo.LinePosition
	{
		private get { } //Length: 4
	}

	private override string System.Xml.IDtdAttributeInfo.LocalName
	{
		private get { } //Length: 27
	}

	private override string System.Xml.IDtdAttributeInfo.Prefix
	{
		private get { } //Length: 7
	}

	private override string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
	{
		private get { } //Length: 77
	}

	private override object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
	{
		private get { } //Length: 5
	}

	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
	{
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
	{
		private get { } //Length: 4
	}

	internal XmlTokenizedType TokenizedType
	{
		internal get { } //Length: 42
		internal set { } //Length: 41
	}

	internal int ValueLineNumber
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal int ValueLinePosition
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	private static SchemaAttDef() { }

	private SchemaAttDef() { }

	public SchemaAttDef(XmlQualifiedName name, string prefix) { }

	public SchemaAttDef(XmlQualifiedName name) { }

	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	internal SchemaAttDef Clone() { }

	internal bool get_DefaultValueChecked() { }

	internal string get_DefaultValueExpanded() { }

	internal int get_LineNumber() { }

	internal int get_LinePosition() { }

	internal Reserve get_Reserved() { }

	internal XmlSchemaAttribute get_SchemaAttribute() { }

	internal XmlTokenizedType get_TokenizedType() { }

	internal int get_ValueLineNumber() { }

	internal int get_ValueLinePosition() { }

	internal void set_DefaultValueExpanded(string value) { }

	internal void set_LineNumber(int value) { }

	internal void set_LinePosition(int value) { }

	internal void set_Reserved(Reserve value) { }

	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	internal void set_TokenizedType(XmlTokenizedType value) { }

	internal void set_ValueLineNumber(int value) { }

	internal void set_ValueLinePosition(int value) { }

	private override bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	private override bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	private override bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	private override int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	private override int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	private override string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	private override string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	private override string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	private override object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

}

