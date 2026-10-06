namespace UnityEngine.Purchasing;

internal class JSONSerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProductDefinition, String> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SerializeProductStoreSpecificIds>b__2_0(ProductDefinition product) { }

	}


	public JSONSerializer() { }

	private static string BuildPurchaseFailureDescriptionMessage(Dictionary<String, Object> dic) { }

	public static StoreConnectionFailureDescription DeserializeConnectionFailureDescription(string json) { }

	public static PurchaseFailureDescription DeserializeFailureReason(string json, IProductCache productCache) { }

	public static Dictionary<String, Dictionary`2<String, Object>> DeserializeFetchedPurchases(string json) { }

	private static ProductMetadata DeserializeMetadata(Dictionary<String, Object> data) { }

	public static List<ProductDescription> DeserializeProductDescriptions(string json) { }

	public static List<ProductDescription> DeserializeProductDescriptionsFromFetchProductsSk2(string json) { }

	public static Dictionary<String, String> DeserializeProductDetails(string json) { }

	public static ProductFetchFailureDescription DeserializeProductFetchFailureDescription(string json) { }

	public static Dictionary<String, Object> DeserializePurchaseDetails(string purchaseDetailJson) { }

	public static PurchasesFetchFailureDescription DeserializePurchasesFetchFailureDescription(string json) { }

	public static Dictionary<String, String> DeserializeSubscriptionDescriptions(string json) { }

	private static Dictionary<String, Object> EncodeProductDef(ProductDefinition product) { }

	private static Dictionary<String, Object> EncodeProductDesc(ProductDescription product) { }

	private static Dictionary<String, Object> EncodeProductMeta(ProductMetadata product) { }

	public static string SerializeProductDef(ProductDefinition product) { }

	public static string SerializeProductDefs(IEnumerable<ProductDefinition> products) { }

	public static string SerializeProductDescs(IEnumerable<ProductDescription> products) { }

	public static string SerializeProductDescs(ProductDescription product) { }

	public static string SerializeProductStoreSpecificIds(IEnumerable<ProductDefinition> products) { }

}

