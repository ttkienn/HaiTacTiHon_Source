namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping
{
	private bool _hasWrapperElement; //Field offset: 0x48
	private XmlMemberMapping[] _mapping; //Field offset: 0x50

	public int Count
	{
		 get { } //Length: 26
	}

	internal bool HasWrapperElement
	{
		internal get { } //Length: 5
	}

	public int get_Count() { }

	internal bool get_HasWrapperElement() { }

}

