namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlArrayItemAttributes : CollectionBase
{

	public XmlArrayItemAttribute Item
	{
		 get { } //Length: 169
	}

	public XmlArrayItemAttributes() { }

	public int Add(XmlArrayItemAttribute attribute) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public XmlArrayItemAttribute get_Item(int index) { }

}

