namespace MS.Internal.Xml.XPath;

internal class Filter : AstNode
{
	private AstNode _input; //Field offset: 0x10
	private AstNode _condition; //Field offset: 0x18

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Filter(AstNode input, AstNode condition) { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

