namespace System.Xml.Schema;

internal abstract class SchemaDeclBase
{
	public enum Use
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4,
	}

	protected XmlQualifiedName name; //Field offset: 0x10
	protected string prefix; //Field offset: 0x18
	protected bool isDeclaredInExternal; //Field offset: 0x20
	protected Use presence; //Field offset: 0x24
	protected XmlSchemaType schemaType; //Field offset: 0x28
	protected XmlSchemaDatatype datatype; //Field offset: 0x30
	protected string defaultValueRaw; //Field offset: 0x38
	protected object defaultValueTyped; //Field offset: 0x40
	protected long maxLength; //Field offset: 0x48
	protected long minLength; //Field offset: 0x50
	protected List<String> values; //Field offset: 0x58

	internal XmlSchemaDatatype Datatype
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal string DefaultValueRaw
	{
		internal get { } //Length: 77
		internal set { } //Length: 13
	}

	internal object DefaultValueTyped
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal bool IsDeclaredInExternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal long MaxLength
	{
		internal get { } //Length: 5
		internal set { } //Length: 5
	}

	internal long MinLength
	{
		internal get { } //Length: 5
		internal set { } //Length: 5
	}

	internal XmlQualifiedName Name
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal string Prefix
	{
		internal get { } //Length: 77
		internal set { } //Length: 13
	}

	internal Use Presence
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal XmlSchemaType SchemaType
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal List<String> Values
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	protected SchemaDeclBase(XmlQualifiedName name, string prefix) { }

	protected SchemaDeclBase() { }

	internal void AddValue(string value) { }

	internal bool CheckEnumeration(object pVal) { }

	internal bool CheckValue(object pVal) { }

	internal XmlSchemaDatatype get_Datatype() { }

	internal string get_DefaultValueRaw() { }

	internal object get_DefaultValueTyped() { }

	internal bool get_IsDeclaredInExternal() { }

	internal long get_MaxLength() { }

	internal long get_MinLength() { }

	internal XmlQualifiedName get_Name() { }

	internal string get_Prefix() { }

	internal Use get_Presence() { }

	internal XmlSchemaType get_SchemaType() { }

	internal List<String> get_Values() { }

	internal void set_Datatype(XmlSchemaDatatype value) { }

	internal void set_DefaultValueRaw(string value) { }

	internal void set_DefaultValueTyped(object value) { }

	internal void set_IsDeclaredInExternal(bool value) { }

	internal void set_MaxLength(long value) { }

	internal void set_MinLength(long value) { }

	internal void set_Name(XmlQualifiedName value) { }

	internal void set_Prefix(string value) { }

	internal void set_Presence(Use value) { }

	internal void set_SchemaType(XmlSchemaType value) { }

	internal void set_Values(List<String> value) { }

}

