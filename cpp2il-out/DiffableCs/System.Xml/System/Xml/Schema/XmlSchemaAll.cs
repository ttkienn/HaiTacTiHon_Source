namespace System.Xml.Schema;

public class XmlSchemaAll : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	internal virtual bool IsEmpty
	{
		internal get { } //Length: 60
	}

	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		 get { } //Length: 5
	}

	public XmlSchemaAll() { }

	internal virtual bool get_IsEmpty() { }

	public virtual XmlSchemaObjectCollection get_Items() { }

	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

