namespace Newtonsoft.Json.Converters;

[NullableContext(1)]
internal interface IXmlDocument : IXmlNode
{

	[Nullable(2)]
	public IXmlElement DocumentElement
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public IXmlNode CreateAttribute(string name, string value) { }

	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	public IXmlNode CreateCDataSection(string data) { }

	public IXmlNode CreateComment(string text) { }

	public IXmlElement CreateElement(string elementName) { }

	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	public IXmlNode CreateSignificantWhitespace(string text) { }

	public IXmlNode CreateTextNode(string text) { }

	public IXmlNode CreateWhitespace(string text) { }

	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[NullableContext(2)]
	public IXmlElement get_DocumentElement() { }

}

