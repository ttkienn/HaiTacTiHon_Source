namespace MS.Internal.Xml.XPath;

internal class Axis : AstNode
{
	internal enum AxisType
	{
		Ancestor = 0,
		AncestorOrSelf = 1,
		Attribute = 2,
		Child = 3,
		Descendant = 4,
		DescendantOrSelf = 5,
		Following = 6,
		FollowingSibling = 7,
		Namespace = 8,
		Parent = 9,
		Preceding = 10,
		PrecedingSibling = 11,
		Self = 12,
		None = 13,
	}

	private AxisType _axisType; //Field offset: 0x10
	private AstNode _input; //Field offset: 0x18
	private string _prefix; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private XPathNodeType _nodeType; //Field offset: 0x30
	protected bool abbrAxis; //Field offset: 0x34
	private string _urn; //Field offset: 0x38

	public bool AbbrAxis
	{
		 get { } //Length: 5
	}

	public AstNode Input
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public XPathNodeType NodeType
	{
		 get { } //Length: 4
	}

	public string Prefix
	{
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		 get { } //Length: 3
	}

	public AxisType TypeOfAxis
	{
		 get { } //Length: 191
	}

	public string Urn
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	public Axis(AxisType axisType, AstNode input) { }

	public bool get_AbbrAxis() { }

	public AstNode get_Input() { }

	public string get_Name() { }

	public XPathNodeType get_NodeType() { }

	public string get_Prefix() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

	public AxisType get_TypeOfAxis() { }

	public string get_Urn() { }

	public void set_Input(AstNode value) { }

	public void set_Urn(string value) { }

}

