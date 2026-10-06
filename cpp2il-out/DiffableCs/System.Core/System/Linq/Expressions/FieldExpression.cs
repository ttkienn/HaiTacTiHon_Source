namespace System.Linq.Expressions;

internal sealed class FieldExpression : MemberExpression
{
	private readonly FieldInfo _field; //Field offset: 0x18

	public virtual Type Type
	{
		 get { } //Length: 42
	}

	public FieldExpression(Expression expression, FieldInfo member) { }

	public virtual Type get_Type() { }

	internal virtual MemberInfo GetMember() { }

}

