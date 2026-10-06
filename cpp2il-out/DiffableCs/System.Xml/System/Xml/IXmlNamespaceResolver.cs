namespace System.Xml;

public interface IXmlNamespaceResolver
{

	public IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	public string LookupNamespace(string prefix) { }

	public string LookupPrefix(string namespaceName) { }

}

