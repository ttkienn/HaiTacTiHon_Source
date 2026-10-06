namespace System.Xml.Schema;

public interface IXmlSchemaInfo
{

	public bool IsDefault
	{
		 get { } //Length: 0
	}

	public bool IsNil
	{
		 get { } //Length: 0
	}

	public XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 0
	}

	public XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 0
	}

	public XmlSchemaElement SchemaElement
	{
		 get { } //Length: 0
	}

	public XmlSchemaType SchemaType
	{
		 get { } //Length: 0
	}

	public XmlSchemaValidity Validity
	{
		 get { } //Length: 0
	}

	public bool get_IsDefault() { }

	public bool get_IsNil() { }

	public XmlSchemaSimpleType get_MemberType() { }

	public XmlSchemaAttribute get_SchemaAttribute() { }

	public XmlSchemaElement get_SchemaElement() { }

	public XmlSchemaType get_SchemaType() { }

	public XmlSchemaValidity get_Validity() { }

}

