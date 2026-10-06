namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
{
	private readonly XmlDocument _document; //Field offset: 0x28

	[Nullable(2)]
	public override IXmlElement DocumentElement
	{
		[NullableContext(2)]
		 get { } //Length: 164
	}

	public XmlDocumentWrapper(XmlDocument document) { }

	public override IXmlNode CreateAttribute(string name, string value) { }

	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	public override IXmlNode CreateCDataSection(string data) { }

	public override IXmlNode CreateComment(string data) { }

	public override IXmlElement CreateElement(string elementName) { }

	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	public override IXmlNode CreateSignificantWhitespace(string text) { }

	public override IXmlNode CreateTextNode(string text) { }

	public override IXmlNode CreateWhitespace(string text) { }

	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[NullableContext(2)]
	public override IXmlElement get_DocumentElement() { }

}

