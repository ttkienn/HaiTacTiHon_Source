namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class FetchProductsUseCase : IFetchProductsUseCase, IStoreProductsCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public List<ProductDefinition> matchedDefinitions; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		[NullableContext(0)]
		internal bool <InvokeFailureIfIncomplete>b__0(ProductDefinition def) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		[Nullable(0)]
		public FetchProductsUseCase <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public ProductFetchRequest request; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <ProcessValidFetchRequest>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public ProductDescription description; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		[NullableContext(0)]
		internal bool <GetMatchingDefinition>b__0(ProductDefinition definition) { }

	}

	[CompilerGenerated]
	private struct <OnProductsFetchFailed>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public FetchProductsUseCase <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public ProductFetchFailureDescription failureDescription; //Field offset: 0x30
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IStore m_Store; //Field offset: 0x10
	private readonly IRetryService m_RetryService; //Field offset: 0x18
	[Nullable(2)]
	private ProductFetchRequest m_ActiveRequest; //Field offset: 0x20
	[Nullable(2)]
	private IRetryRequest m_ActiveRetryRequest; //Field offset: 0x28

	[Preserve]
	internal FetchProductsUseCase(IStore storeResponsible, IRetryService retryService) { }

	private Product CreateMatchedProduct(ProductDefinition definition, ProductDescription description) { }

	public override void FetchProducts(List<ProductDefinition> productDefinitions, Action<List`1<Product>> fetchSuccessAction, Action<List`1<ProductDefinition>, String> fetchFailureAction, IRetryPolicy retryPolicy) { }

	private ProductDefinition GetMatchingDefinition(ProductDescription description) { }

	private static void InvokeFailureIfIncomplete(ProductFetchRequest request, List<ProductDefinition> matchedDefinitions) { }

	private static void InvokeSuccess(List<Product> fetchedProducts, Action<List`1<Product>> successCallback) { }

	public override void OnProductsFetched(IReadOnlyList<ProductDescription> products) { }

	[AsyncStateMachine(typeof(<OnProductsFetchFailed>d__13))]
	public override void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription) { }

	private void ProcessFetchedProductsAndInvokeCallbacks(ProductFetchRequest request, IReadOnlyList<ProductDescription> productsRetrieved) { }

	private void ProcessValidFetchRequest(ProductFetchRequest request, IRetryPolicy retryPolicy) { }

	private void SendRequestFailureCallback(ProductFetchRequest productFetchRequest, ProductFetchFailureDescription failureDescription) { }

}

