namespace System.Xml.Serialization;

public class XmlTypeMapping : XmlMapping
{
	private string xmlType; //Field offset: 0x48
	private string xmlTypeNamespace; //Field offset: 0x50
	private TypeData type; //Field offset: 0x58
	private XmlTypeMapping baseMap; //Field offset: 0x60
	private bool multiReferenceType; //Field offset: 0x68
	private bool includeInSchema; //Field offset: 0x69
	private bool isNullable; //Field offset: 0x6A
	private bool isAny; //Field offset: 0x6B
	private ArrayList _derivedTypes; //Field offset: 0x70

	internal XmlTypeMapping BaseMap
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal ArrayList DerivedTypes
	{
		internal get { } //Length: 5
	}

	internal bool HasXmlTypeNamespace
	{
		internal get { } //Length: 9
	}

	internal bool IncludeInSchema
	{
		internal set { } //Length: 4
	}

	internal bool IsAny
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool IsNullable
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool MultiReferenceType
	{
		internal get { } //Length: 5
	}

	internal TypeData TypeData
	{
		internal get { } //Length: 5
	}

	public string TypeFullName
	{
		 get { } //Length: 27
	}

	internal string XmlType
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal string XmlTypeNamespace
	{
		internal get { } //Length: 69
		internal set { } //Length: 13
	}

	internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	internal XmlTypeMapping get_BaseMap() { }

	internal ArrayList get_DerivedTypes() { }

	internal bool get_HasXmlTypeNamespace() { }

	internal bool get_IsAny() { }

	internal bool get_IsNullable() { }

	internal bool get_MultiReferenceType() { }

	internal TypeData get_TypeData() { }

	public string get_TypeFullName() { }

	internal string get_XmlType() { }

	internal string get_XmlTypeNamespace() { }

	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	internal void set_BaseMap(XmlTypeMapping value) { }

	internal void set_IncludeInSchema(bool value) { }

	internal void set_IsAny(bool value) { }

	internal void set_IsNullable(bool value) { }

	internal void set_XmlType(string value) { }

	internal void set_XmlTypeNamespace(string value) { }

	internal void UpdateRoot(XmlQualifiedName qname) { }

}

