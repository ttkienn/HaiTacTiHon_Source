namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal class Expression
{
	public ExpressionType type; //Field offset: 0x10
	public ExpressionMultiplier multiplier; //Field offset: 0x14
	public DataType dataType; //Field offset: 0x20
	public ExpressionCombinator combinator; //Field offset: 0x24
	public Expression[] subExpressions; //Field offset: 0x28
	public string keyword; //Field offset: 0x30

	public Expression(ExpressionType type) { }

}

