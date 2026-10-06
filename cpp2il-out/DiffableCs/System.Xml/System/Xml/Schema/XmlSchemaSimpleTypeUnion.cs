namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
{
	private XmlSchemaObjectCollection baseTypes; //Field offset: 0x50
	private XmlQualifiedName[] memberTypes; //Field offset: 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; //Field offset: 0x60

	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes
	{
		 get { } //Length: 5
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes
	{
		 get { } //Length: 5
	}

	[XmlAttribute("memberTypes")]
	public XmlQualifiedName[] MemberTypes
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlSchemaSimpleTypeUnion() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	public XmlSchemaObjectCollection get_BaseTypes() { }

	public XmlQualifiedName[] get_MemberTypes() { }

	public void set_MemberTypes(XmlQualifiedName[] value) { }

	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

}

