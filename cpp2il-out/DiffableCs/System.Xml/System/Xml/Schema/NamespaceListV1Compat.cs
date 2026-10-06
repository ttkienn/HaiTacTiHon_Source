namespace System.Xml.Schema;

internal class NamespaceListV1Compat : NamespaceList
{

	public NamespaceListV1Compat(string namespaces, string targetNamespace) { }

	public virtual bool Allows(string ns) { }

}

