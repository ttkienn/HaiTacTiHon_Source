namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
{
	private XmlQualifiedName itemTypeName; //Field offset: 0x50
	private XmlSchemaSimpleType itemType; //Field offset: 0x58
	private XmlSchemaSimpleType baseItemType; //Field offset: 0x60

	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlAttribute("itemType")]
	public XmlQualifiedName ItemTypeName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public XmlSchemaSimpleTypeList() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleType get_BaseItemType() { }

	public XmlSchemaSimpleType get_ItemType() { }

	public XmlQualifiedName get_ItemTypeName() { }

	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	public void set_ItemType(XmlSchemaSimpleType value) { }

	public void set_ItemTypeName(XmlQualifiedName value) { }

}

