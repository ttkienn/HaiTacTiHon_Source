namespace System.Xml.Schema;

public class XmlSchemaSequence : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	internal virtual bool IsEmpty
	{
		internal get { } //Length: 170
	}

	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public virtual XmlSchemaObjectCollection Items
	{
		 get { } //Length: 5
	}

	public XmlSchemaSequence() { }

	internal virtual bool get_IsEmpty() { }

	public virtual XmlSchemaObjectCollection get_Items() { }

	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

