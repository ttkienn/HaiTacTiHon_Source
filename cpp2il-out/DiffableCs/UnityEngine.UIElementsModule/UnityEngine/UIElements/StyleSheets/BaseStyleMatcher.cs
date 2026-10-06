namespace UnityEngine.UIElements.StyleSheets;

internal abstract class BaseStyleMatcher
{
	private struct MatchContext
	{
		public int valueIndex; //Field offset: 0x0
		public int matchedVariableCount; //Field offset: 0x4

	}

	protected static readonly Regex s_CustomIdentRegex; //Field offset: 0x0
	private Stack<MatchContext> m_ContextStack; //Field offset: 0x10
	private MatchContext m_CurrentContext; //Field offset: 0x18

	public int currentIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool hasCurrent
	{
		 get { } //Length: 39
	}

	public abstract bool isCurrentComma
	{
		 get { } //Length: 0
	}

	public abstract bool isCurrentVariable
	{
		 get { } //Length: 0
	}

	public int matchedVariableCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public abstract int valueCount
	{
		 get { } //Length: 0
	}

	private static BaseStyleMatcher() { }

	protected BaseStyleMatcher() { }

	public void DropContext() { }

	public int get_currentIndex() { }

	public bool get_hasCurrent() { }

	public abstract bool get_isCurrentComma() { }

	public abstract bool get_isCurrentVariable() { }

	public int get_matchedVariableCount() { }

	public abstract int get_valueCount() { }

	protected void Initialize() { }

	protected bool Match(Expression exp) { }

	private bool MatchAndAnd(Expression exp) { }

	protected abstract bool MatchAngle() { }

	protected abstract bool MatchColor() { }

	private bool MatchCombinator(Expression exp) { }

	protected abstract bool MatchCustomIdent() { }

	private bool MatchDataType(Expression exp) { }

	private bool MatchExpression(Expression exp) { }

	private bool MatchExpressionWithMultiplier(Expression exp) { }

	private bool MatchGroup(Expression exp) { }

	protected abstract bool MatchInteger() { }

	private bool MatchJuxtaposition(Expression exp) { }

	protected abstract bool MatchKeyword(string keyword) { }

	protected abstract bool MatchLength() { }

	private int MatchMany(Expression exp) { }

	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	protected abstract bool MatchNumber() { }

	private bool MatchOr(Expression exp) { }

	private bool MatchOrOr(Expression exp) { }

	protected abstract bool MatchPercentage() { }

	protected abstract bool MatchResource() { }

	protected abstract bool MatchTime() { }

	protected abstract bool MatchUrl() { }

	public void MoveNext() { }

	public void RestoreContext() { }

	public void SaveContext() { }

	public void set_currentIndex(int value) { }

	public void set_matchedVariableCount(int value) { }

}

