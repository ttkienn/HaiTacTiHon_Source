namespace System.Xml;

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x20

	public XmlAsyncCheckReaderWithNS(XmlReader reader) { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

