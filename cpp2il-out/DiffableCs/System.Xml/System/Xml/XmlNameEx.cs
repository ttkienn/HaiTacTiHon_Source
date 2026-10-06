namespace System.Xml;

internal sealed class XmlNameEx : XmlName
{
	private byte flags; //Field offset: 0x48
	private XmlSchemaSimpleType memberType; //Field offset: 0x50
	private XmlSchemaType schemaType; //Field offset: 0x58
	private object decl; //Field offset: 0x60

	public virtual bool IsDefault
	{
		 get { } //Length: 8
	}

	public virtual bool IsNil
	{
		 get { } //Length: 8
	}

	public virtual XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 5
	}

	public virtual XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 130
	}

	public virtual XmlSchemaElement SchemaElement
	{
		 get { } //Length: 130
	}

	public virtual XmlSchemaType SchemaType
	{
		 get { } //Length: 5
	}

	public virtual XmlSchemaValidity Validity
	{
		 get { } //Length: 43
	}

	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsNil() { }

	public virtual XmlSchemaSimpleType get_MemberType() { }

	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	public virtual XmlSchemaElement get_SchemaElement() { }

	public virtual XmlSchemaType get_SchemaType() { }

	public virtual XmlSchemaValidity get_Validity() { }

	public void SetIsDefault(bool value) { }

	public void SetIsNil(bool value) { }

	public void SetValidity(XmlSchemaValidity value) { }

}

