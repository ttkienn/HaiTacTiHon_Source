namespace System.Xml.Serialization;

internal class XmlTypeMapMemberElement : XmlTypeMapMember
{
	private XmlTypeMapElementInfoList _elementInfo; //Field offset: 0x58
	private string _choiceMember; //Field offset: 0x60
	private bool _isTextCollector; //Field offset: 0x68
	private TypeData _choiceTypeData; //Field offset: 0x70

	public string ChoiceMember
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public TypeData ChoiceTypeData
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlTypeMapElementInfoList ElementInfo
	{
		 get { } //Length: 105
		 set { } //Length: 13
	}

	public bool IsXmlTextCollector
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public XmlTypeMapMemberElement() { }

	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	public string get_ChoiceMember() { }

	public TypeData get_ChoiceTypeData() { }

	public XmlTypeMapElementInfoList get_ElementInfo() { }

	public bool get_IsXmlTextCollector() { }

	public void set_ChoiceMember(string value) { }

	public void set_ChoiceTypeData(TypeData value) { }

	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	public void set_IsXmlTextCollector(bool value) { }

	public void SetChoice(object ob, object choice) { }

}

