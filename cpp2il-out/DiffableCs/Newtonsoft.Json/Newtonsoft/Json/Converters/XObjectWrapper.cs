namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XObjectWrapper : IXmlNode
{
	private readonly XObject _xmlObject; //Field offset: 0x10

	[Nullable(1)]
	public override List<IXmlNode> Attributes
	{
		[NullableContext(1)]
		 get { } //Length: 78
	}

	[Nullable(1)]
	public override List<IXmlNode> ChildNodes
	{
		[NullableContext(1)]
		 get { } //Length: 78
	}

	public override string LocalName
	{
		 get { } //Length: 3
	}

	public override string NamespaceUri
	{
		 get { } //Length: 3
	}

	public override XmlNodeType NodeType
	{
		 get { } //Length: 32
	}

	public override IXmlNode ParentNode
	{
		 get { } //Length: 3
	}

	public override string Value
	{
		 get { } //Length: 3
		 set { } //Length: 62
	}

	public override object WrappedNode
	{
		 get { } //Length: 5
	}

	public XObjectWrapper(XObject xmlObject) { }

	[NullableContext(1)]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(1)]
	public override List<IXmlNode> get_Attributes() { }

	[NullableContext(1)]
	public override List<IXmlNode> get_ChildNodes() { }

	public override string get_LocalName() { }

	public override string get_NamespaceUri() { }

	public override XmlNodeType get_NodeType() { }

	public override IXmlNode get_ParentNode() { }

	public override string get_Value() { }

	public override object get_WrappedNode() { }

	public override void set_Value(string value) { }

}

