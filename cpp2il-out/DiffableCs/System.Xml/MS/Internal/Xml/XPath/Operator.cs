namespace MS.Internal.Xml.XPath;

internal class Operator : AstNode
{
	internal enum Op
	{
		INVALID = 0,
		OR = 1,
		AND = 2,
		EQ = 3,
		NE = 4,
		LT = 5,
		LE = 6,
		GT = 7,
		GE = 8,
		PLUS = 9,
		MINUS = 10,
		MUL = 11,
		DIV = 12,
		MOD = 13,
		UNION = 14,
	}

	private static Op[] s_invertOp; //Field offset: 0x0
	private Op _opType; //Field offset: 0x10
	private AstNode _opnd1; //Field offset: 0x18
	private AstNode _opnd2; //Field offset: 0x20

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 27
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	private static Operator() { }

	public Operator(Op op, AstNode opnd1, AstNode opnd2) { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

