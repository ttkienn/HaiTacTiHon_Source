namespace MS.Internal.Xml.XPath;

internal class XPathParser
{
	private class ParamInfo
	{
		private FunctionType _ftype; //Field offset: 0x10
		private int _minargs; //Field offset: 0x14
		private int _maxargs; //Field offset: 0x18
		private XPathResultType[] _argTypes; //Field offset: 0x20

		public XPathResultType[] ArgTypes
		{
			 get { } //Length: 5
		}

		public FunctionType FType
		{
			 get { } //Length: 191
		}

		public int Maxargs
		{
			 get { } //Length: 4
		}

		public int Minargs
		{
			 get { } //Length: 4
		}

		internal ParamInfo(FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

		public XPathResultType[] get_ArgTypes() { }

		public FunctionType get_FType() { }

		public int get_Maxargs() { }

		public int get_Minargs() { }

	}

	private static readonly XPathResultType[] s_temparray1; //Field offset: 0x0
	private static readonly XPathResultType[] s_temparray2; //Field offset: 0x8
	private static readonly XPathResultType[] s_temparray3; //Field offset: 0x10
	private static readonly XPathResultType[] s_temparray4; //Field offset: 0x18
	private static readonly XPathResultType[] s_temparray5; //Field offset: 0x20
	private static readonly XPathResultType[] s_temparray6; //Field offset: 0x28
	private static readonly XPathResultType[] s_temparray7; //Field offset: 0x30
	private static readonly XPathResultType[] s_temparray8; //Field offset: 0x38
	private static readonly XPathResultType[] s_temparray9; //Field offset: 0x40
	private static Dictionary<String, ParamInfo> s_functionTable; //Field offset: 0x48
	private static Dictionary<String, AxisType> s_AxesTable; //Field offset: 0x50
	private XPathScanner _scanner; //Field offset: 0x10
	private int _parseDepth; //Field offset: 0x18

	private static XPathParser() { }

	private XPathParser(XPathScanner scanner) { }

	private void CheckNodeSet(XPathResultType t) { }

	private void CheckToken(LexKind t) { }

	private static Dictionary<String, AxisType> CreateAxesTable() { }

	private static Dictionary<String, ParamInfo> CreateFunctionTable() { }

	private AxisType GetAxis() { }

	private static bool IsNodeType(XPathScanner scaner) { }

	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	private static bool IsStep(LexKind lexKind) { }

	private void NextLex() { }

	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	private AstNode ParseAndExpr(AstNode qyInput) { }

	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	private AstNode ParseExpression(AstNode qyInput) { }

	private AstNode ParseFilterExpr(AstNode qyInput) { }

	private AstNode ParseLocationPath(AstNode qyInput) { }

	private AstNode ParseMethod(AstNode qyInput) { }

	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	private AstNode ParseOrExpr(AstNode qyInput) { }

	private AstNode ParsePathExpr(AstNode qyInput) { }

	private AstNode ParsePredicate(AstNode qyInput) { }

	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	private AstNode ParseStep(AstNode qyInput) { }

	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	private AstNode ParseUnionExpr(AstNode qyInput) { }

	public static AstNode ParseXPathExpression(string xpathExpression) { }

	private void PassToken(LexKind t) { }

	private bool TestOp(string op) { }

}

