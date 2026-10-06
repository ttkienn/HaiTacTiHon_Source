namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
internal interface IXmlNode
{

	[Nullable(1)]
	public List<IXmlNode> Attributes
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	[Nullable(1)]
	public List<IXmlNode> ChildNodes
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	public string LocalName
	{
		 get { } //Length: 0
	}

	public string NamespaceUri
	{
		 get { } //Length: 0
	}

	public XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public IXmlNode ParentNode
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object WrappedNode
	{
		 get { } //Length: 0
	}

	[NullableContext(1)]
	public IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(1)]
	public List<IXmlNode> get_Attributes() { }

	[NullableContext(1)]
	public List<IXmlNode> get_ChildNodes() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XmlNodeType get_NodeType() { }

	public IXmlNode get_ParentNode() { }

	public string get_Value() { }

	public object get_WrappedNode() { }

	public void set_Value(string value) { }

}

