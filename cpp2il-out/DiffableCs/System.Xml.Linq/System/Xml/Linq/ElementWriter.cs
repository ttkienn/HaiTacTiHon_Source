namespace System.Xml.Linq;

internal struct ElementWriter
{
	private XmlWriter _writer; //Field offset: 0x0
	private NamespaceResolver _resolver; //Field offset: 0x8

	public ElementWriter(XmlWriter writer) { }

	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	private void PushAncestors(XElement e) { }

	private void PushElement(XElement e) { }

	public void WriteElement(XElement e) { }

	private void WriteEndElement() { }

	private void WriteFullEndElement() { }

	private void WriteStartElement(XElement e) { }

}

