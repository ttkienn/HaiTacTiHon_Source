namespace System.Dynamic;

[DebuggerDisplay("{DebugView}")]
[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
public abstract class BindingRestrictions
{
	private sealed class BindingRestrictionsProxy
	{

	}

	private sealed class CustomRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10

		internal CustomRestriction(Expression expression) { }

		public virtual bool Equals(object obj) { }

		internal virtual Expression GetExpression() { }

		public virtual int GetHashCode() { }

	}

	private sealed class InstanceRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10
		private readonly object _instance; //Field offset: 0x18

		internal InstanceRestriction(Expression parameter, object instance) { }

		public virtual bool Equals(object obj) { }

		internal virtual Expression GetExpression() { }

		public virtual int GetHashCode() { }

	}

	private sealed class MergedRestriction : BindingRestrictions
	{
		internal readonly BindingRestrictions Left; //Field offset: 0x10
		internal readonly BindingRestrictions Right; //Field offset: 0x18

		internal MergedRestriction(BindingRestrictions left, BindingRestrictions right) { }

		internal virtual Expression GetExpression() { }

	}

	private sealed class TestBuilder
	{
		private struct AndNode
		{
			internal int Depth; //Field offset: 0x0
			internal Expression Node; //Field offset: 0x8

		}

		private readonly HashSet<BindingRestrictions> _unique; //Field offset: 0x10
		private readonly Stack<AndNode> _tests; //Field offset: 0x18

		public TestBuilder() { }

		internal void Append(BindingRestrictions restrictions) { }

		private void Push(Expression node, int depth) { }

		internal Expression ToExpression() { }

	}

	private sealed class TypeRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10
		private readonly Type _type; //Field offset: 0x18

		internal TypeRestriction(Expression parameter, Type type) { }

		public virtual bool Equals(object obj) { }

		internal virtual Expression GetExpression() { }

		public virtual int GetHashCode() { }

	}

	public static readonly BindingRestrictions Empty; //Field offset: 0x0

	private static BindingRestrictions() { }

	private BindingRestrictions() { }

	internal abstract Expression GetExpression() { }

	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	public Expression ToExpression() { }

}

