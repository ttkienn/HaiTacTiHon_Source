namespace System.Linq.Expressions;

internal sealed class PropertyExpression : MemberExpression
{
	private readonly PropertyInfo _property; //Field offset: 0x18

	public virtual Type Type
	{
		 get { } //Length: 42
	}

	public PropertyExpression(Expression expression, PropertyInfo member) { }

	public virtual Type get_Type() { }

	internal virtual MemberInfo GetMember() { }

}

