namespace System.Xml.Schema;

internal class NamespaceList
{
	internal enum ListType
	{
		Any = 0,
		Other = 1,
		Set = 2,
	}

	private ListType type; //Field offset: 0x10
	private Hashtable set; //Field offset: 0x18
	private string targetNamespace; //Field offset: 0x20

	public ICollection Enumerate
	{
		 get { } //Length: 115
	}

	public string Excluded
	{
		 get { } //Length: 5
	}

	public ListType Type
	{
		 get { } //Length: 191
	}

	public NamespaceList() { }

	public NamespaceList(string namespaces, string targetNamespace) { }

	public override bool Allows(string ns) { }

	public bool Allows(XmlQualifiedName qname) { }

	public NamespaceList Clone() { }

	private NamespaceList CompareSetToOther(NamespaceList other) { }

	public ICollection get_Enumerate() { }

	public string get_Excluded() { }

	public ListType get_Type() { }

	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	private void RemoveNamespace(string tns) { }

	public virtual string ToString() { }

	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

}

