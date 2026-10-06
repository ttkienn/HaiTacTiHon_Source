namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal struct ExpressionMultiplier
{
	public const int Infinity = 100; //Field offset: 0x0
	private ExpressionMultiplierType m_Type; //Field offset: 0x0
	public int min; //Field offset: 0x4
	public int max; //Field offset: 0x8

	public ExpressionMultiplierType type
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public ExpressionMultiplier(ExpressionMultiplierType type = 0) { }

	public ExpressionMultiplierType get_type() { }

	public void set_type(ExpressionMultiplierType value) { }

	private void SetType(ExpressionMultiplierType value) { }

}

