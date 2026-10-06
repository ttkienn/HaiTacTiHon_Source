namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal class StyleSyntaxParser
{
	private List<Expression> m_ProcessExpressionList; //Field offset: 0x10
	private Stack<Expression> m_ExpressionStack; //Field offset: 0x18
	private Stack<ExpressionCombinator> m_CombinatorStack; //Field offset: 0x20
	private Dictionary<String, Expression> m_ParsedExpressionCache; //Field offset: 0x28

	public StyleSyntaxParser() { }

	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	private static bool IsCombinator(StyleSyntaxToken token) { }

	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	private static bool IsMultiplier(StyleSyntaxToken token) { }

	public Expression Parse(string syntax) { }

	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	private Expression ParseNonTerminalValue(string syntax) { }

	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	private void ProcessCombinatorStack() { }

}

