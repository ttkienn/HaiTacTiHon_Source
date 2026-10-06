namespace MS.Internal.Xml.XPath;

internal class Root : AstNode
{

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Root() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

