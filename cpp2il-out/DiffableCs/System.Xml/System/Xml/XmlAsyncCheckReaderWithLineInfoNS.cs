namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x28

	public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader) { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

