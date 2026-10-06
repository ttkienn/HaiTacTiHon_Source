namespace System.Xml.Serialization;

internal class ListMap : ObjectMap
{
	private XmlTypeMapElementInfoList _itemInfo; //Field offset: 0x10
	private string _choiceMember; //Field offset: 0x18

	public string ChoiceMember
	{
		 set { } //Length: 13
	}

	public XmlTypeMapElementInfoList ItemInfo
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public ListMap() { }

	public virtual bool Equals(object other) { }

	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	public XmlTypeMapElementInfo FindTextElement() { }

	public XmlTypeMapElementInfoList get_ItemInfo() { }

	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	public virtual int GetHashCode() { }

	public void set_ChoiceMember(string value) { }

	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

}

