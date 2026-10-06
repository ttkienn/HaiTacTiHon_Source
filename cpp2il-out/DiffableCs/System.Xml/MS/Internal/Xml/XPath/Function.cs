namespace MS.Internal.Xml.XPath;

internal class Function : AstNode
{
	internal enum FunctionType
	{
		FuncLast = 0,
		FuncPosition = 1,
		FuncCount = 2,
		FuncID = 3,
		FuncLocalName = 4,
		FuncNameSpaceUri = 5,
		FuncName = 6,
		FuncString = 7,
		FuncBoolean = 8,
		FuncNumber = 9,
		FuncTrue = 10,
		FuncFalse = 11,
		FuncNot = 12,
		FuncConcat = 13,
		FuncStartsWith = 14,
		FuncContains = 15,
		FuncSubstringBefore = 16,
		FuncSubstringAfter = 17,
		FuncSubstring = 18,
		FuncStringLength = 19,
		FuncNormalize = 20,
		FuncTranslate = 21,
		FuncLang = 22,
		FuncSum = 23,
		FuncFloor = 24,
		FuncCeiling = 25,
		FuncRound = 26,
		FuncUserDefined = 27,
	}

	internal static XPathResultType[] ReturnTypes; //Field offset: 0x0
	private FunctionType _functionType; //Field offset: 0x10
	private List<AstNode> _argumentList; //Field offset: 0x18
	private string _name; //Field offset: 0x20
	private string _prefix; //Field offset: 0x28

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 113
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	private static Function() { }

	public Function(FunctionType ftype, List<AstNode> argumentList) { }

	public Function(string prefix, string name, List<AstNode> argumentList) { }

	public Function(FunctionType ftype, AstNode arg) { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

