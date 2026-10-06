namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class QueryProductDetailsService : IQueryProductDetailsService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<Boolean, Boolean> <>9__9_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<ProductDefinition, Boolean> <>9__11_0; //Field offset: 0x10
		[Nullable(0)]
		public static Func<ProductDefinition, String> <>9__11_1; //Field offset: 0x18
		[Nullable(0)]
		public static Func<ProductDefinition, Boolean> <>9__12_0; //Field offset: 0x20
		[Nullable(0)]
		public static Func<ProductDefinition, String> <>9__12_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <AreAllProductDetailsCached>b__9_0(bool isCached) { }

		[NullableContext(0)]
		internal bool <QueryInAppsAsync>b__11_0(ProductDefinition product) { }

		[NullableContext(0)]
		internal string <QueryInAppsAsync>b__11_1(ProductDefinition product) { }

		[NullableContext(0)]
		internal bool <QuerySubsAsync>b__12_0(ProductDefinition product) { }

		[NullableContext(0)]
		internal string <QuerySubsAsync>b__12_1(ProductDefinition product) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 1, 1}])]
		public TaskCompletionSource<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>> taskCompletionSource; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		[NullableContext(0)]
		internal void <QueryProductDetails>b__0(IGoogleBillingResult billingResult, List<AndroidJavaObject> productDetails) { }

	}

	[CompilerGenerated]
	private struct <QueryInAppsAndSubsProductDetails>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<ProductDetailsQueryResponse> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public QueryProductDetailsService <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 0, 1, 1, 1}])]
		private List<Task`1<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>>> <tasks>5__2; //Field offset: 0x30
		[Nullable(0)]
		private TaskAwaiter<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>[]> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryProductDescriptions>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public AsyncTaskMethodBuilder<List`1<ProductDescription>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public QueryProductDetailsService <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<AndroidJavaObject>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryProductDetails>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public AsyncTaskMethodBuilder<List`1<AndroidJavaObject>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public QueryProductDetailsService <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private TaskAwaiter<ProductDetailsQueryResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10
	private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; //Field offset: 0x18
	private readonly IProductDetailsConverter m_ProductDetailsConverter; //Field offset: 0x20

	[Preserve]
	internal QueryProductDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter) { }

	private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products) { }

	private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products) { }

	[AsyncStateMachine(typeof(<QueryInAppsAndSubsProductDetails>d__7))]
	private Task<ProductDetailsQueryResponse> QueryInAppsAndSubsProductDetails(IReadOnlyCollection<ProductDefinition> products) { }

	private Task<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>> QueryInAppsAsync(IEnumerable<ProductDefinition> products) { }

	[AsyncStateMachine(typeof(<QueryProductDescriptions>d__5))]
	public override Task<List`1<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products) { }

	public override Task<List`1<AndroidJavaObject>> QueryProductDetails(ProductDefinition product) { }

	[AsyncStateMachine(typeof(<QueryProductDetails>d__6))]
	public override Task<List`1<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products) { }

	private Task<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>> QueryProductDetails(List<String> productList, string type) { }

	private Task<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>> QuerySubsAsync(IEnumerable<ProductDefinition> products) { }

	private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse) { }

}

