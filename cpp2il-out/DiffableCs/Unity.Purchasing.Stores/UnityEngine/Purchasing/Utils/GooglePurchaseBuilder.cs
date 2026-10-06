namespace UnityEngine.Purchasing.Utils;

internal class GooglePurchaseBuilder : IGooglePurchaseBuilder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IEnumerable<AndroidJavaObject> productDetails; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal AndroidJavaObject <TryFindAllProductDetails>b__0(string sku) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public string sku; //Field offset: 0x10

		public <>c__DisplayClass6_1() { }

		internal bool <TryFindAllProductDetails>b__1(AndroidJavaObject productDetail) { }

	}

	private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; //Field offset: 0x10
	private readonly ILogger m_Logger; //Field offset: 0x18

	[Preserve]
	internal GooglePurchaseBuilder(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger) { }

	public IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

	public override IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases) { }

	private void LogWarningForException(Exception exception) { }

	private static IEnumerable<AndroidJavaObject> TryFindAllProductDetails(IEnumerable<String> skus, IEnumerable<AndroidJavaObject> productDetails) { }

}

