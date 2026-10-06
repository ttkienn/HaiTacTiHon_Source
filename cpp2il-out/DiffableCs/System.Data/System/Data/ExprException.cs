namespace System.Data;

internal sealed class ExprException
{

	private static EvaluateException _Eval(string error) { }

	private static EvaluateException _Eval(string error, Exception innerException) { }

	private static InvalidExpressionException _Expr(string error) { }

	private static OverflowException _Overflow(string error) { }

	private static SyntaxErrorException _Syntax(string error) { }

	public static Exception AggregateArgument() { }

	public static Exception AggregateUnbound(string expr) { }

	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	public static Exception ArgumentType(string function, int arg, Type type) { }

	public static Exception ArgumentTypeInteger(string function, int arg) { }

	internal static EvaluateException BindFailure(string relationName) { }

	public static Exception ComputeNotAggregate(string expr) { }

	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	public static Exception EvalNoContext() { }

	public static Exception ExpressionTooComplex() { }

	public static Exception ExpressionUnbound(string expr) { }

	public static Exception FilterConvertion(string expr) { }

	public static Exception FunctionArgumentCount(string name) { }

	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	public static Exception InvalidDate(string date) { }

	public static Exception InvalidHoursArgument() { }

	public static Exception InvalidIsSyntax() { }

	public static Exception InvalidMinutesArgument() { }

	public static Exception InvalidName(string name) { }

	public static Exception InvalidNameBracketing(string name) { }

	public static Exception InvalidPattern(string pat) { }

	public static Exception InvalidString(string str) { }

	public static Exception InvalidTimeZoneRange() { }

	public static Exception InvalidType(string typeName) { }

	public static Exception InvokeArgument() { }

	public static Exception InWithoutList() { }

	public static Exception InWithoutParentheses() { }

	public static Exception LookupArgument() { }

	public static Exception MismatchKindandTimeSpan() { }

	public static Exception MissingOperand(OperatorInfo before) { }

	public static Exception MissingOperandBefore(string op) { }

	public static Exception MissingOperator(string token) { }

	public static Exception MissingRightParen() { }

	public static Exception NonConstantArgument() { }

	public static Exception NYI(string moreinfo) { }

	public static Exception Overflow(Type type) { }

	public static Exception SyntaxError() { }

	public static Exception TooManyRightParentheses() { }

	public static Exception TypeMismatch(string expr) { }

	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	public static Exception UnboundName(string name) { }

	public static Exception UndefinedFunction(string name) { }

	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	public static Exception UnknownToken(string token, int position) { }

	public static Exception UnresolvedRelation(string name, string expr) { }

	public static Exception UnsupportedDataType(Type type) { }

	public static Exception UnsupportedOperator(int op) { }

}

