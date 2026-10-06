namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class ProductCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Product, String> <>9__6_0; //Field offset: 0x8
		public static Func<Product, String> <>9__7_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <WithID>b__6_0(Product x) { }

		internal string <WithStoreSpecificID>b__7_0(Product x) { }

	}

	private Dictionary<String, Product> m_IdToProduct; //Field offset: 0x10
	private Dictionary<String, Product> m_StoreSpecificIdToProduct; //Field offset: 0x18

	public Product[] all
	{
		 get { } //Length: 100
	}

	public HashSet<Product> set
	{
		 get { } //Length: 200
	}

	public ProductCollection() { }

	public Product[] get_all() { }

	public HashSet<Product> get_set() { }

	public Product WithID(string id) { }

	public Product WithStoreSpecificID(string id) { }

}

