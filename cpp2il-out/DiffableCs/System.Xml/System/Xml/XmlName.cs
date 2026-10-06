namespace System.Xml;

internal class XmlName : IXmlSchemaInfo
{
	private string prefix; //Field offset: 0x10
	private string localName; //Field offset: 0x18
	private string ns; //Field offset: 0x20
	private string name; //Field offset: 0x28
	private int hashCode; //Field offset: 0x30
	internal XmlDocument ownerDoc; //Field offset: 0x38
	internal XmlName next; //Field offset: 0x40

	public int HashCode
	{
		 get { } //Length: 4
	}

	public override bool IsDefault
	{
		 get { } //Length: 3
	}

	public override bool IsNil
	{
		 get { } //Length: 3
	}

	public string LocalName
	{
		 get { } //Length: 5
	}

	public override XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 3
	}

	public string Name
	{
		 get { } //Length: 404
	}

	public string NamespaceURI
	{
		 get { } //Length: 5
	}

	public XmlDocument OwnerDocument
	{
		 get { } //Length: 5
	}

	public string Prefix
	{
		 get { } //Length: 5
	}

	public override XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 3
	}

	public override XmlSchemaElement SchemaElement
	{
		 get { } //Length: 3
	}

	public override XmlSchemaType SchemaType
	{
		 get { } //Length: 3
	}

	public override XmlSchemaValidity Validity
	{
		 get { } //Length: 3
	}

	internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

	public int get_HashCode() { }

	public override bool get_IsDefault() { }

	public override bool get_IsNil() { }

	public string get_LocalName() { }

	public override XmlSchemaSimpleType get_MemberType() { }

	public string get_Name() { }

	public string get_NamespaceURI() { }

	public XmlDocument get_OwnerDocument() { }

	public string get_Prefix() { }

	public override XmlSchemaAttribute get_SchemaAttribute() { }

	public override XmlSchemaElement get_SchemaElement() { }

	public override XmlSchemaType get_SchemaType() { }

	public override XmlSchemaValidity get_Validity() { }

	public static int GetHashCode(string name) { }

}

