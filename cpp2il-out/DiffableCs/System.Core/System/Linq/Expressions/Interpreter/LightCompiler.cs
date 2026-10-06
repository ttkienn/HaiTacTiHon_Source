namespace System.Linq.Expressions.Interpreter;

internal sealed class LightCompiler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Expression, Boolean> <>9__56_1; //Field offset: 0x8
		public static Func<SwitchCase, Boolean> <>9__56_0; //Field offset: 0x10
		public static Action<LightCompiler, Expression> <>9__101_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <CompileNoLabelPush>b__101_0(LightCompiler this, Expression e) { }

		internal bool <CompileSwitchExpression>b__56_0(SwitchCase c) { }

		internal bool <CompileSwitchExpression>b__56_1(Expression t) { }

	}

	private sealed class QuoteVisitor : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, Int32> _definedParameters; //Field offset: 0x10
		public readonly HashSet<ParameterExpression> _hoistedParameters; //Field offset: 0x18

		public QuoteVisitor() { }

		private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

		private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

		protected private virtual Expression VisitBlock(BlockExpression node) { }

		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		protected private virtual Expression VisitLambda(Expression<T> node) { }

		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	private static readonly LocalDefinition[] s_emptyLocals; //Field offset: 0x0
	private readonly InstructionList _instructions; //Field offset: 0x10
	private readonly LocalVariables _locals; //Field offset: 0x18
	private readonly List<DebugInfo> _debugInfos; //Field offset: 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; //Field offset: 0x28
	private LabelScopeInfo _labelBlock; //Field offset: 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; //Field offset: 0x38
	private readonly LightCompiler _parent; //Field offset: 0x40
	private readonly StackGuard _guard; //Field offset: 0x48

	public InstructionList Instructions
	{
		 get { } //Length: 5
	}

	private static LightCompiler() { }

	public LightCompiler() { }

	private LightCompiler(LightCompiler parent) { }

	private void CheckRethrow() { }

	private void Compile(Expression expr, bool asVoid) { }

	private void Compile(Expression expr) { }

	private ByRefUpdater CompileAddress(Expression node, int index) { }

	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	private void CompileAsVoid(Expression expr) { }

	private void CompileBinaryExpression(Expression expr) { }

	private void CompileBlockEnd(LocalDefinition[] locals) { }

	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	private void CompileCoalesceBinaryExpression(Expression expr) { }

	private void CompileComparison(BinaryExpression node) { }

	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	private void CompileConstantExpression(Expression expr) { }

	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	private void CompileConvertUnaryExpression(Expression expr) { }

	private void CompileDebugInfoExpression(Expression expr) { }

	private void CompileDefaultExpression(Type type) { }

	private void CompileDefaultExpression(Expression expr) { }

	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	private void CompileGetVariable(ParameterExpression variable) { }

	private void CompileGotoExpression(Expression expr) { }

	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	private void CompileIndexExpression(Expression expr) { }

	private void CompileIntSwitchExpression(SwitchExpression node) { }

	private void CompileInvocationExpression(Expression expr) { }

	private void CompileLabelExpression(Expression expr) { }

	private void CompileLambdaExpression(Expression expr) { }

	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	private void CompileListInitExpression(Expression expr) { }

	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	private void CompileLoopExpression(Expression expr) { }

	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	private void CompileMemberExpression(Expression expr) { }

	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	private void CompileMemberInitExpression(Expression expr) { }

	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	private void CompileMethodCallExpression(Expression expr) { }

	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	private void CompileNewArrayExpression(Expression expr) { }

	private void CompileNewExpression(Expression expr) { }

	private void CompileNoLabelPush(Expression expr) { }

	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	private void CompileNotExpression(UnaryExpression node) { }

	private void CompileOrElseBinaryExpression(Expression expr) { }

	private void CompileParameterExpression(Expression expr) { }

	private void CompileQuoteUnaryExpression(Expression expr) { }

	private void CompileRuntimeVariablesExpression(Expression expr) { }

	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	private void CompileStringSwitchExpression(SwitchExpression node) { }

	private void CompileSwitchExpression(Expression expr) { }

	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	private void CompileTryExpression(Expression expr) { }

	private void CompileTryFaultExpression(TryExpression expr) { }

	private void CompileTypeAsExpression(UnaryExpression node) { }

	private void CompileTypeEqualExpression(Expression expr) { }

	private void CompileTypeIsExpression(Expression expr) { }

	private void CompileUnaryExpression(Expression expr) { }

	private void CompileUnboxUnaryExpression(Expression expr) { }

	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	private void DefineBlockLabels(Expression node) { }

	private LabelInfo DefineLabel(LabelTarget node) { }

	private void EmitCopyValueType(Type valueType) { }

	private void EmitIndexGet(IndexExpression index) { }

	private void EmitThisForMethodCall(Expression node) { }

	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	private void EmitUnaryMethodCall(UnaryExpression node) { }

	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	private LabelInfo EnsureLabel(LabelTarget node) { }

	public InstructionList get_Instructions() { }

	private static Type GetMemberType(MemberInfo member) { }

	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	private Interpreter MakeInterpreter(string lambdaName) { }

	private bool MaybeMutableValueType(Type type) { }

	private void PopLabelBlock(LabelScopeKind kind) { }

	private void PushLabelBlock(LabelScopeKind type) { }

	private LabelInfo ReferenceLabel(LabelTarget node) { }

	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	private static bool ShouldWritebackNode(Expression node) { }

	private bool TryPushLabelBlock(Expression node) { }

}

