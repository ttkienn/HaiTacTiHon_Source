namespace System.Xml;

public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
{
	private struct NamespaceDeclaration
	{
		public string prefix; //Field offset: 0x0
		public string uri; //Field offset: 0x8
		public int scopeId; //Field offset: 0x10
		public int previousNsIndex; //Field offset: 0x14

		public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

	}

	private NamespaceDeclaration[] nsdecls; //Field offset: 0x10
	private int lastDecl; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private int scopeId; //Field offset: 0x28
	private Dictionary<String, Int32> hashTable; //Field offset: 0x30
	private bool useHashtable; //Field offset: 0x38
	private string xml; //Field offset: 0x40
	private string xmlNs; //Field offset: 0x48

	public override string DefaultNamespace
	{
		 get { } //Length: 104
	}

	public override XmlNameTable NameTable
	{
		 get { } //Length: 5
	}

	internal XmlNamespaceManager() { }

	public XmlNamespaceManager(XmlNameTable nameTable) { }

	public override void AddNamespace(string prefix, string uri) { }

	public override string get_DefaultNamespace() { }

	public override XmlNameTable get_NameTable() { }

	public override IEnumerator GetEnumerator() { }

	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	public override string LookupNamespace(string prefix) { }

	private int LookupNamespaceDecl(string prefix) { }

	public override string LookupPrefix(string uri) { }

	public override bool PopScope() { }

	public override void PushScope() { }

	public override void RemoveNamespace(string prefix, string uri) { }

}

