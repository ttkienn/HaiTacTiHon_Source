namespace System.Runtime.CompilerServices;

public class CallSite : CallSite
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Converter<ParameterInfo, ParameterExpression> <>9__20_0; //Field offset: 0x0
		public static Converter<ParameterExpression, Expression> <>9__20_1; //Field offset: 0x0
		public static Converter<ParameterInfo, ParameterExpression> <>9__21_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ParameterExpression <CreateCustomNoMatchDelegate>b__21_0(ParameterInfo p) { }

		internal ParameterExpression <CreateCustomUpdateDelegate>b__20_0(ParameterInfo p) { }

		internal Expression <CreateCustomUpdateDelegate>b__20_1(ParameterExpression p) { }

	}

	private static T s_cachedUpdate; //Field offset: 0x0
	private static T s_cachedNoMatch; //Field offset: 0x0
	public T Target; //Field offset: 0x0
	internal T[] Rules; //Field offset: 0x0

	public T Update
	{
		 get { } //Length: 108
	}

	private CallSite`1(CallSiteBinder binder) { }

	private CallSite`1() { }

	internal void AddRule(T newRule) { }

	private static Expression Convert(Expression arg, Type type) { }

	public static CallSite<T> Create(CallSiteBinder binder) { }

	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }

	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }

	internal CallSite<T> CreateMatchMaker() { }

	public T get_Update() { }

	private T GetUpdateDelegate() { }

	private T GetUpdateDelegate(ref T addr) { }

	internal T MakeUpdateDelegate() { }

	internal void MoveRule(int i) { }

}

