namespace System.Xml.Schema;

public abstract class XmlSchemaGroupBase : XmlSchemaParticle
{

	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items
	{
		 get { } //Length: 0
	}

	protected XmlSchemaGroupBase() { }

	public abstract XmlSchemaObjectCollection get_Items() { }

	internal abstract void SetItems(XmlSchemaObjectCollection newItems) { }

}

