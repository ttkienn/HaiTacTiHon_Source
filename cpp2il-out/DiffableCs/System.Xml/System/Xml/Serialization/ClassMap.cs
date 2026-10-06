namespace System.Xml.Serialization;

internal class ClassMap : ObjectMap
{
	private Hashtable _elements; //Field offset: 0x10
	private ArrayList _elementMembers; //Field offset: 0x18
	private Hashtable _attributeMembers; //Field offset: 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; //Field offset: 0x28
	private ArrayList _flatLists; //Field offset: 0x30
	private ArrayList _allMembers; //Field offset: 0x38
	private ArrayList _membersWithDefault; //Field offset: 0x40
	private ArrayList _listMembers; //Field offset: 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; //Field offset: 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; //Field offset: 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; //Field offset: 0x60
	private XmlTypeMapMember _xmlTextCollector; //Field offset: 0x68
	private XmlTypeMapMember _returnMember; //Field offset: 0x70
	private bool _ignoreMemberNamespace; //Field offset: 0x78
	private bool _canBeSimpleType; //Field offset: 0x79
	private Nullable<Boolean> _isOrderDependentMap; //Field offset: 0x7A

	public ArrayList AllMembers
	{
		 get { } //Length: 5
	}

	public ICollection AttributeMembers
	{
		 get { } //Length: 793
	}

	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
	{
		 get { } //Length: 5
	}

	public XmlTypeMapMemberAnyElement DefaultAnyElementMember
	{
		 get { } //Length: 5
	}

	public ICollection ElementMembers
	{
		 get { } //Length: 5
	}

	public ArrayList FlatLists
	{
		 get { } //Length: 5
	}

	public bool HasSimpleContent
	{
		 get { } //Length: 89
	}

	public bool IsOrderDependentMap
	{
		 get { } //Length: 640
	}

	public ArrayList ListMembers
	{
		 get { } //Length: 5
	}

	public XmlTypeMapMemberNamespaces NamespaceDeclarations
	{
		 get { } //Length: 5
	}

	public XmlTypeMapMember ReturnMember
	{
		 get { } //Length: 5
	}

	public XmlQualifiedName SimpleContentBaseType
	{
		 get { } //Length: 532
	}

	public XmlTypeMapMember XmlTextCollector
	{
		 get { } //Length: 5
	}

	public ClassMap() { }

	public void AddMember(XmlTypeMapMember member) { }

	private string BuildKey(string name, string ns, int explicitOrder) { }

	public ArrayList get_AllMembers() { }

	public ICollection get_AttributeMembers() { }

	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	public ICollection get_ElementMembers() { }

	public ArrayList get_FlatLists() { }

	public bool get_HasSimpleContent() { }

	public bool get_IsOrderDependentMap() { }

	public ArrayList get_ListMembers() { }

	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	public XmlTypeMapMember get_ReturnMember() { }

	public XmlQualifiedName get_SimpleContentBaseType() { }

	public XmlTypeMapMember get_XmlTextCollector() { }

	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	public void SetCanBeSimpleType(bool can) { }

}

