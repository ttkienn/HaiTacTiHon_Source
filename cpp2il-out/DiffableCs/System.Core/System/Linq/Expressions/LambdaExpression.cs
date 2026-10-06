namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider
{
	private readonly Expression _body; //Field offset: 0x10

	public Expression Body
	{
		 get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 20
	}

	internal override string NameCore
	{
		internal get { } //Length: 3
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	[ExcludeFromCodeCoverage]
	internal override int ParameterCount
	{
		internal get { } //Length: 39
	}

	internal abstract Type PublicType
	{
		internal get { } //Length: 0
	}

	public Type ReturnType
	{
		 get { } //Length: 131
	}

	[ExcludeFromCodeCoverage]
	private override int System.Linq.Expressions.IParameterProvider.ParameterCount
	{
		private get { } //Length: 20
	}

	public bool TailCall
	{
		 get { } //Length: 20
	}

	internal override bool TailCallCore
	{
		internal get { } //Length: 3
	}

	public virtual Type Type
	{
		 get { } //Length: 20
	}

	internal abstract Type TypeCore
	{
		internal get { } //Length: 0
	}

	internal LambdaExpression(Expression body) { }

	public Expression get_Body() { }

	public string get_Name() { }

	internal override string get_NameCore() { }

	public virtual ExpressionType get_NodeType() { }

	internal override int get_ParameterCount() { }

	internal abstract Type get_PublicType() { }

	public Type get_ReturnType() { }

	public bool get_TailCall() { }

	internal override bool get_TailCallCore() { }

	public virtual Type get_Type() { }

	internal abstract Type get_TypeCore() { }

	[ExcludeFromCodeCoverage]
	internal override ParameterExpression GetParameter(int index) { }

	private override int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	[ExcludeFromCodeCoverage]
	private override ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

}

