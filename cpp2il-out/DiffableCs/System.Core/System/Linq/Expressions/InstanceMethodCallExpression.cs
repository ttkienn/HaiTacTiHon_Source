namespace System.Linq.Expressions;

internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	private readonly Expression _instance; //Field offset: 0x18

	public InstanceMethodCallExpression(MethodInfo method, Expression instance) { }

	internal virtual Expression GetInstance() { }

}

