namespace System.Data;

internal sealed class SimpleType : ISerializable
{
	private string _baseType; //Field offset: 0x10
	private SimpleType _baseSimpleType; //Field offset: 0x18
	private XmlQualifiedName _xmlBaseType; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private int _length; //Field offset: 0x30
	private int _minLength; //Field offset: 0x34
	private int _maxLength; //Field offset: 0x38
	private string _pattern; //Field offset: 0x40
	private string _ns; //Field offset: 0x48
	private string _maxExclusive; //Field offset: 0x50
	private string _maxInclusive; //Field offset: 0x58
	private string _minExclusive; //Field offset: 0x60
	private string _minInclusive; //Field offset: 0x68
	internal string _enumeration; //Field offset: 0x70

	internal SimpleType BaseSimpleType
	{
		internal get { } //Length: 5
	}

	internal string BaseType
	{
		internal get { } //Length: 5
	}

	internal int Length
	{
		internal get { } //Length: 4
	}

	internal int MaxLength
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal string Name
	{
		internal get { } //Length: 5
	}

	internal string Namespace
	{
		internal get { } //Length: 5
	}

	public string SimpleTypeQualifiedName
	{
		 get { } //Length: 94
	}

	internal XmlQualifiedName XmlBaseType
	{
		internal get { } //Length: 5
	}

	internal SimpleType(string baseType) { }

	internal SimpleType(XmlSchemaSimpleType node) { }

	internal bool CanHaveMaxLength() { }

	internal void ConvertToAnnonymousSimpleType() { }

	internal static SimpleType CreateByteArrayType(string encoding) { }

	internal static SimpleType CreateEnumeratedType(string values) { }

	internal static SimpleType CreateLimitedStringType(int length) { }

	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	internal SimpleType get_BaseSimpleType() { }

	internal string get_BaseType() { }

	internal int get_Length() { }

	internal int get_MaxLength() { }

	internal string get_Name() { }

	internal string get_Namespace() { }

	public string get_SimpleTypeQualifiedName() { }

	internal XmlQualifiedName get_XmlBaseType() { }

	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	internal bool IsPlainString() { }

	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	internal string QualifiedName(string name) { }

	internal void set_MaxLength(int value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

}

