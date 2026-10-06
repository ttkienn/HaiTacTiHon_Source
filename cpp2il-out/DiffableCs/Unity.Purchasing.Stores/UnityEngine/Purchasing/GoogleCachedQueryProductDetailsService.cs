namespace UnityEngine.Purchasing;

[Preserve]
internal class GoogleCachedQueryProductDetailsService : IGoogleCachedQueryProductDetailsService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProductDefinition, String> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetCachedQueriedProductDetails>b__5_0(ProductDefinition product) { }

	}

	private readonly ConcurrentDictionary<String, AndroidJavaObject> m_CachedQueriedProductDetails; //Field offset: 0x10

	public GoogleCachedQueryProductDetailsService() { }

	public override void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts) { }

	private bool Contains(string productId) { }

	public override bool Contains(ProductDefinition products) { }

	protected virtual void Finalize() { }

	private AndroidJavaObject GetCachedQueriedProductDetails(string productId) { }

	private IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<String> productIds) { }

	public override IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products) { }

	public override IEnumerable<AndroidJavaObject> GetCachedQueriedProducts() { }

}

