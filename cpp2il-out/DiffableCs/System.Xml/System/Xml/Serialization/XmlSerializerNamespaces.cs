namespace System.Xml.Serialization;

public class XmlSerializerNamespaces
{
	private Hashtable namespaces; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 141
	}

	internal ArrayList NamespaceList
	{
		internal get { } //Length: 1026
	}

	internal Hashtable Namespaces
	{
		internal get { } //Length: 105
		internal set { } //Length: 13
	}

	public XmlSerializerNamespaces() { }

	public void Add(string prefix, string ns) { }

	internal void AddInternal(string prefix, string ns) { }

	public int get_Count() { }

	internal ArrayList get_NamespaceList() { }

	internal Hashtable get_Namespaces() { }

	internal void set_Namespaces(Hashtable value) { }

	public XmlQualifiedName[] ToArray() { }

}

