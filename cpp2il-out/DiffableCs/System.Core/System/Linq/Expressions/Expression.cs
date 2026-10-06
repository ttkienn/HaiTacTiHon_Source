namespace System.Linq.Expressions;

public abstract class Expression
{
	public class BinaryExpressionProxy
	{

	}

	public class BlockExpressionProxy
	{

	}

	public class CatchBlockProxy
	{

	}

	public class ConditionalExpressionProxy
	{

	}

	public class ConstantExpressionProxy
	{

	}

	public class DebugInfoExpressionProxy
	{

	}

	public class DefaultExpressionProxy
	{

	}

	private class ExtensionInfo
	{
		internal readonly ExpressionType NodeType; //Field offset: 0x10
		internal readonly Type Type; //Field offset: 0x18

	}

	public class GotoExpressionProxy
	{

	}

	public class IndexExpressionProxy
	{

	}

	public class InvocationExpressionProxy
	{

	}

	public class LabelExpressionProxy
	{

	}

	public class LambdaExpressionProxy
	{

	}

	public class ListInitExpressionProxy
	{

	}

	public class LoopExpressionProxy
	{

	}

	public class MemberExpressionProxy
	{

	}

	public class MemberInitExpressionProxy
	{

	}

	public class MethodCallExpressionProxy
	{

	}

	public class NewArrayExpressionProxy
	{

	}

	public class NewExpressionProxy
	{

	}

	public class ParameterExpressionProxy
	{

	}

	public class RuntimeVariablesExpressionProxy
	{

	}

	public class SwitchCaseProxy
	{

	}

	public class SwitchExpressionProxy
	{

	}

	public class TryExpressionProxy
	{

	}

	public class TypeBinaryExpressionProxy
	{

	}

	public class UnaryExpressionProxy
	{

	}

	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; //Field offset: 0x0
	private static CacheDict<Type, Func`5<Expression, String, Boolean, ReadOnlyCollection`1<ParameterExpression>, LambdaExpression>> s_lambdaFactories; //Field offset: 0x8
	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable; //Field offset: 0x10

	public override bool CanReduce
	{
		 get { } //Length: 3
	}

	public override ExpressionType NodeType
	{
		 get { } //Length: 234
	}

	public override Type Type
	{
		 get { } //Length: 235
	}

	private static Expression() { }

	protected Expression() { }

	protected private override Expression Accept(ExpressionVisitor visitor) { }

	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	public static UnaryExpression ArrayLength(Expression array) { }

	public static BinaryExpression Assign(Expression left, Expression right) { }

	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	public static BlockExpression Block(Type type, Expression[] expressions) { }

	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	public static GotoExpression Break(LabelTarget target) { }

	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	internal static MethodCallExpression Call(MethodInfo method) { }

	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	public static ConstantExpression Constant(object value) { }

	public static ConstantExpression Constant(object value, Type type) { }

	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	public static UnaryExpression Convert(Expression expression, Type type) { }

	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	public static DefaultExpression Default(Type type) { }

	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static DefaultExpression Empty() { }

	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static BinaryExpression Equal(Expression left, Expression right) { }

	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	public static MemberExpression Field(Expression expression, string fieldName) { }

	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	public override bool get_CanReduce() { }

	public override ExpressionType get_NodeType() { }

	public override Type get_Type() { }

	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	private static Type GetResultTypeOfShift(Type left, Type right) { }

	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	public static GotoExpression Goto(LabelTarget target, Type type) { }

	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	internal static InvocationExpression Invoke(Expression expression) { }

	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	private static bool IsNullComparison(Expression left, Expression right) { }

	private static bool IsNullConstant(Expression e) { }

	private static bool IsSimpleShift(Type left, Type right) { }

	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	public static LabelExpression Label(LabelTarget target) { }

	public static LabelTarget Label(Type type, string name) { }

	public static LabelTarget Label(Type type) { }

	public static LabelTarget Label(string name) { }

	public static LabelTarget Label() { }

	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	public static Expression<TDelegate> Lambda(Expression body, IEnumerable<ParameterExpression> parameters) { }

	public static Expression<TDelegate> Lambda(Expression body, ParameterExpression[] parameters) { }

	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	public static Expression<TDelegate> Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	public static Expression<TDelegate> Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	public static UnaryExpression Not(Expression expression) { }

	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	public static ParameterExpression Parameter(Type type) { }

	public static ParameterExpression Parameter(Type type, string name) { }

	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	public static MemberExpression Property(Expression expression, string propertyName) { }

	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	public static UnaryExpression Quote(Expression expression) { }

	public override Expression Reduce() { }

	public Expression ReduceAndCheck() { }

	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	private static void RequiresCanWrite(Expression expression, string paramName) { }

	public static GotoExpression Return(LabelTarget target, Expression value) { }

	public static GotoExpression Return(LabelTarget target) { }

	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	public static UnaryExpression Throw(Expression value, Type type) { }

	public virtual string ToString() { }

	public static TryExpression TryFinally(Expression body, Expression finally) { }

	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	public static UnaryExpression Unbox(Expression expression, Type type) { }

	private static void Validate(Type type, bool allowByRef) { }

	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression>& arguments, string methodParamName) { }

	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression>& argList) { }

	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	private static void ValidateOperator(MethodInfo method) { }

	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	public static ParameterExpression Variable(Type type, string name) { }

	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	protected private override Expression VisitChildren(ExpressionVisitor visitor) { }

}

