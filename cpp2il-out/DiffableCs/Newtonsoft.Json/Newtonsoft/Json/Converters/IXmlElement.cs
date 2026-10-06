namespace Newtonsoft.Json.Converters;

[NullableContext(1)]
internal interface IXmlElement : IXmlNode
{

	public bool IsEmpty
	{
		 get { } //Length: 0
	}

	public bool get_IsEmpty() { }

	public string GetPrefixOfNamespace(string namespaceUri) { }

	public void SetAttributeNode(IXmlNode attribute) { }

}

