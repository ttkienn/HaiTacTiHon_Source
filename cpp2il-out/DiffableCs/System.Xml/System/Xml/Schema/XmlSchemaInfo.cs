namespace System.Xml.Schema;

public class XmlSchemaInfo : IXmlSchemaInfo
{
	private bool isDefault; //Field offset: 0x10
	private bool isNil; //Field offset: 0x11
	private XmlSchemaElement schemaElement; //Field offset: 0x18
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x20
	private XmlSchemaType schemaType; //Field offset: 0x28
	private XmlSchemaSimpleType memberType; //Field offset: 0x30
	private XmlSchemaValidity validity; //Field offset: 0x38
	private XmlSchemaContentType contentType; //Field offset: 0x3C

	public XmlSchemaContentType ContentType
	{
		 get { } //Length: 4
	}

	internal bool HasDefaultValue
	{
		internal get { } //Length: 52
	}

	public override bool IsDefault
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override bool IsNil
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal bool IsUnionType
	{
		internal get { } //Length: 63
	}

	public override XmlSchemaSimpleType MemberType
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public override XmlSchemaAttribute SchemaAttribute
	{
		 get { } //Length: 5
		 set { } //Length: 64
	}

	public override XmlSchemaElement SchemaElement
	{
		 get { } //Length: 5
		 set { } //Length: 64
	}

	public override XmlSchemaType SchemaType
	{
		 get { } //Length: 5
		 set { } //Length: 71
	}

	public override XmlSchemaValidity Validity
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal XmlSchemaType XmlType
	{
		internal get { } //Length: 17
	}

	public XmlSchemaInfo() { }

	internal XmlSchemaInfo(XmlSchemaValidity validity) { }

	internal void Clear() { }

	public XmlSchemaContentType get_ContentType() { }

	internal bool get_HasDefaultValue() { }

	public override bool get_IsDefault() { }

	public override bool get_IsNil() { }

	internal bool get_IsUnionType() { }

	public override XmlSchemaSimpleType get_MemberType() { }

	public override XmlSchemaAttribute get_SchemaAttribute() { }

	public override XmlSchemaElement get_SchemaElement() { }

	public override XmlSchemaType get_SchemaType() { }

	public override XmlSchemaValidity get_Validity() { }

	internal XmlSchemaType get_XmlType() { }

	public void set_IsDefault(bool value) { }

	public void set_IsNil(bool value) { }

	public void set_MemberType(XmlSchemaSimpleType value) { }

	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	public void set_SchemaElement(XmlSchemaElement value) { }

	public void set_SchemaType(XmlSchemaType value) { }

	public void set_Validity(XmlSchemaValidity value) { }

}

