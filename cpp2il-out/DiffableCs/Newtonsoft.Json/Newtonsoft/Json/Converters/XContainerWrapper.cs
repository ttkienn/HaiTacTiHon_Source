namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XContainerWrapper : XObjectWrapper
{
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<IXmlNode> _childNodes; //Field offset: 0x18

	public virtual List<IXmlNode> ChildNodes
	{
		 get { } //Length: 799
	}

	private XContainer Container
	{
		private get { } //Length: 107
	}

	protected override bool HasChildNodes
	{
		 get { } //Length: 123
	}

	[Nullable(2)]
	public virtual IXmlNode ParentNode
	{
		[NullableContext(2)]
		 get { } //Length: 162
	}

	public XContainerWrapper(XContainer container) { }

	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	public virtual List<IXmlNode> get_ChildNodes() { }

	private XContainer get_Container() { }

	protected override bool get_HasChildNodes() { }

	[NullableContext(2)]
	public virtual IXmlNode get_ParentNode() { }

	internal static IXmlNode WrapNode(XObject node) { }

}

