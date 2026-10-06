namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class SymbolsDictionary
{
	private int last; //Field offset: 0x10
	private Hashtable names; //Field offset: 0x18
	private Hashtable wildcards; //Field offset: 0x20
	private ArrayList particles; //Field offset: 0x28
	private object particleLast; //Field offset: 0x30
	private bool isUpaEnforced; //Field offset: 0x38

	public int Count
	{
		 get { } //Length: 6
	}

	public bool IsUpaEnforced
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int Item
	{
		 get { } //Length: 230
	}

	public SymbolsDictionary() { }

	public int AddName(XmlQualifiedName name, object particle) { }

	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	private void AddWildcard(string wildcard, object particle) { }

	public bool Exists(XmlQualifiedName name) { }

	public int get_Count() { }

	public bool get_IsUpaEnforced() { }

	public int get_Item(XmlQualifiedName name) { }

	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	public object GetParticle(int symbol) { }

	public string NameOf(int symbol) { }

	public void set_IsUpaEnforced(bool value) { }

}

