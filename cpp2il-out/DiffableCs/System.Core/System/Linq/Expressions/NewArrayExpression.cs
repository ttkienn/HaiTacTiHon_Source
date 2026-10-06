namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
public class NewArrayExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; //Field offset: 0x18

	public ReadOnlyCollection<Expression> Expressions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }

}

