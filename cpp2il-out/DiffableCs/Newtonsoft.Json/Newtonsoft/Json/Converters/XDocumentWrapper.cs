namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
{

	public virtual List<IXmlNode> ChildNodes
	{
		 get { } //Length: 405
	}

	private XDocument Document
	{
		private get { } //Length: 107
	}

	[Nullable(2)]
	public override IXmlElement DocumentElement
	{
		[NullableContext(2)]
		 get { } //Length: 246
	}

	protected virtual bool HasChildNodes
	{
		 get { } //Length: 153
	}

	public XDocumentWrapper(XDocument document) { }

	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	public override IXmlNode CreateAttribute(string name, string value) { }

	public override IXmlNode CreateCDataSection(string data) { }

	public override IXmlNode CreateComment(string text) { }

	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	public override IXmlElement CreateElement(string elementName) { }

	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	public override IXmlNode CreateSignificantWhitespace(string text) { }

	public override IXmlNode CreateTextNode(string text) { }

	public override IXmlNode CreateWhitespace(string text) { }

	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	public virtual List<IXmlNode> get_ChildNodes() { }

	private XDocument get_Document() { }

	[NullableContext(2)]
	public override IXmlElement get_DocumentElement() { }

	protected virtual bool get_HasChildNodes() { }

}

