namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class UnityPurchasing
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IStoreListener storeListener; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		[NullableContext(1)]
		internal void <AddProductServiceListeners>b__0(List<Product> _) { }

		[NullableContext(1)]
		internal void <AddProductServiceListeners>b__1(ProductFetchFailed failed) { }

	}

	[CompilerGenerated]
	private struct <ConnectToStoreAndFetchProducts>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal static ConfigurationBuilder m_ConfigurationBuilder; //Field offset: 0x0
	internal static IStoreListener m_StoreListener; //Field offset: 0x8
	internal static bool shouldFetchProductsAtInit; //Field offset: 0x10
	private static bool isInitialized; //Field offset: 0x11
	internal static PurchasingManager m_PurchasingManager; //Field offset: 0x18

	private static UnityPurchasing() { }

	public UnityPurchasing() { }

	private static void AddProductServiceListeners(IStoreListener storeListener, IProductService productService) { }

	[AsyncStateMachine(typeof(<ConnectToStoreAndFetchProducts>d__8))]
	private static void ConnectToStoreAndFetchProducts() { }

	private static void FetchProducts(IStoreListener storeListener, ConfigurationBuilder configurationBuilder) { }

	public static void Initialize(IStoreListener storeListener, ConfigurationBuilder configurationBuilder) { }

}

