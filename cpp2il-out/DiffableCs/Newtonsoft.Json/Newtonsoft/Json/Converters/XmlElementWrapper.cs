namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
{
	private readonly XmlElement _element; //Field offset: 0x28

	public override bool IsEmpty
	{
		 get { } //Length: 29
	}

	public XmlElementWrapper(XmlElement element) { }

	public override bool get_IsEmpty() { }

	public override string GetPrefixOfNamespace(string namespaceUri) { }

	public override void SetAttributeNode(IXmlNode attribute) { }

}

