namespace System.Runtime.CompilerServices;

public abstract class CallSiteBinder
{
	private sealed class LambdaSignature
	{
		private static LambdaSignature<T> s_instance; //Field offset: 0x0
		internal readonly ReadOnlyCollection<ParameterExpression> Parameters; //Field offset: 0x0
		internal readonly LabelTarget ReturnLabel; //Field offset: 0x0

		internal static LambdaSignature<T> Instance
		{
			internal get { } //Length: 391
		}

		private LambdaSignature`1() { }

		internal static LambdaSignature<T> get_Instance() { }

	}

	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; //Field offset: 0x0
	internal Dictionary<Type, Object> Cache; //Field offset: 0x10

	public static LabelTarget UpdateLabel
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private static CallSiteBinder() { }

	protected CallSiteBinder() { }

	public abstract Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	internal T BindCore(CallSite<T> site, Object[] args) { }

	public override T BindDelegate(CallSite<T> site, Object[] args) { }

	protected void CacheTarget(T target) { }

	[CompilerGenerated]
	public static LabelTarget get_UpdateLabel() { }

	internal RuleCache<T> GetRuleCache() { }

	private static Expression<T> Stitch(Expression binding, LambdaSignature<T> signature) { }

}

