namespace MS.Internal.Xml.XPath;

internal abstract class AstNode
{
	internal enum AstType
	{
		Axis = 0,
		Operator = 1,
		Filter = 2,
		ConstantOperand = 3,
		Function = 4,
		Group = 5,
		Root = 6,
		Variable = 7,
		Error = 8,
	}


	public abstract XPathResultType ReturnType
	{
		 get { } //Length: 0
	}

	public abstract AstType Type
	{
		 get { } //Length: 0
	}

	protected AstNode() { }

	public abstract XPathResultType get_ReturnType() { }

	public abstract AstType get_Type() { }

}

