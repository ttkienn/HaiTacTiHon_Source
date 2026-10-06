namespace System.Linq.Expressions;

public abstract class ExpressionVisitor
{

	protected ExpressionVisitor() { }

	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	private static void ValidateChildType(Type before, Type after, string methodName) { }

	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	public static ReadOnlyCollection<T> Visit(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }

	public override Expression Visit(Expression node) { }

	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	public T VisitAndConvert(T node, string callerName) { }

	public ReadOnlyCollection<T> VisitAndConvert(ReadOnlyCollection<T> nodes, string callerName) { }

	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	protected private override Expression VisitBinary(BinaryExpression node) { }

	protected private override Expression VisitBlock(BlockExpression node) { }

	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	protected private override Expression VisitConditional(ConditionalExpression node) { }

	protected private override Expression VisitConstant(ConstantExpression node) { }

	protected private override Expression VisitDefault(DefaultExpression node) { }

	protected private override Expression VisitExtension(Expression node) { }

	protected private override Expression VisitGoto(GotoExpression node) { }

	protected private override Expression VisitIndex(IndexExpression node) { }

	protected private override Expression VisitInvocation(InvocationExpression node) { }

	protected private override Expression VisitLabel(LabelExpression node) { }

	protected override LabelTarget VisitLabelTarget(LabelTarget node) { }

	protected private override Expression VisitLambda(Expression<T> node) { }

	protected private override Expression VisitLoop(LoopExpression node) { }

	protected private override Expression VisitMember(MemberExpression node) { }

	protected private override Expression VisitMethodCall(MethodCallExpression node) { }

	protected private override Expression VisitNewArray(NewArrayExpression node) { }

	protected private override Expression VisitParameter(ParameterExpression node) { }

	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	protected private override Expression VisitTry(TryExpression node) { }

	protected private override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	protected private override Expression VisitUnary(UnaryExpression node) { }

}

