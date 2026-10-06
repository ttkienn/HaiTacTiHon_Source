namespace MS.Internal.Xml.XPath;

internal class Operand : AstNode
{
	private XPathResultType _type; //Field offset: 0x10
	private object _val; //Field offset: 0x18

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 191
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Operand(string val) { }

	public Operand(double val) { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

