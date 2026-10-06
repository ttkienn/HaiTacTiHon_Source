namespace System.Linq.Expressions;

internal sealed class ExpressionStringBuilder : ExpressionVisitor
{
	private readonly StringBuilder _out; //Field offset: 0x10
	private Dictionary<Object, Int32> _ids; //Field offset: 0x18

	private ExpressionStringBuilder() { }

	internal static string CatchBlockToString(CatchBlock node) { }

	private void DumpLabel(LabelTarget target) { }

	internal static string ExpressionToString(Expression node) { }

	private int GetId(object o) { }

	private int GetLabelId(LabelTarget label) { }

	private int GetParamId(ParameterExpression p) { }

	private static bool IsBool(Expression node) { }

	private void Out(string s) { }

	private void Out(char c) { }

	private void OutMember(Expression instance, MemberInfo member) { }

	public virtual string ToString() { }

	protected private virtual Expression VisitBinary(BinaryExpression node) { }

	protected private virtual Expression VisitBlock(BlockExpression node) { }

	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	protected private virtual Expression VisitConditional(ConditionalExpression node) { }

	protected private virtual Expression VisitConstant(ConstantExpression node) { }

	protected private virtual Expression VisitDefault(DefaultExpression node) { }

	private void VisitExpressions(char open, ReadOnlyCollection<T> expressions, char close) { }

	private void VisitExpressions(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }

	protected private virtual Expression VisitExtension(Expression node) { }

	protected private virtual Expression VisitGoto(GotoExpression node) { }

	protected private virtual Expression VisitIndex(IndexExpression node) { }

	protected private virtual Expression VisitInvocation(InvocationExpression node) { }

	protected private virtual Expression VisitLabel(LabelExpression node) { }

	protected private virtual Expression VisitLambda(Expression<T> node) { }

	protected private virtual Expression VisitLoop(LoopExpression node) { }

	protected private virtual Expression VisitMember(MemberExpression node) { }

	protected private virtual Expression VisitMethodCall(MethodCallExpression node) { }

	protected private virtual Expression VisitNewArray(NewArrayExpression node) { }

	protected private virtual Expression VisitParameter(ParameterExpression node) { }

	protected private virtual Expression VisitTry(TryExpression node) { }

	protected private virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	protected private virtual Expression VisitUnary(UnaryExpression node) { }

}

