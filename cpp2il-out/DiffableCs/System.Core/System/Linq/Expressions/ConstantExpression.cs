namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
public class ConstantExpression : Expression
{
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; //Field offset: 0x10

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 115
	}

	public object Value
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ConstantExpression(object value) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	[CompilerGenerated]
	public object get_Value() { }

}

