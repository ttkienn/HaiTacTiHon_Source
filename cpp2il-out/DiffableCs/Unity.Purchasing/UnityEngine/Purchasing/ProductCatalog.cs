namespace UnityEngine.Purchasing;

public class ProductCatalog
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProductCatalogItem, Boolean> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_allValidProducts>b__9_0(ProductCatalogItem x) { }

	}

	private static IProductCatalogImpl instance; //Field offset: 0x0
	public const string kCatalogPath = "Assets/Resources/IAPProductCatalog.json"; //Field offset: 0x0
	public const string kPrevCatalogPath = "Assets/Plugins/UnityPurchasing/Resources/IAPProductCatalog.json"; //Field offset: 0x0
	public string appleSKU; //Field offset: 0x10
	public string appleTeamID; //Field offset: 0x18
	public bool enableCodelessAutoInitialization; //Field offset: 0x20
	public bool enableUnityGamingServicesAutoInitialization; //Field offset: 0x21
	[SerializeField]
	private List<ProductCatalogItem> products; //Field offset: 0x28

	public ICollection<ProductCatalogItem> allProducts
	{
		 get { } //Length: 5
	}

	public ICollection<ProductCatalogItem> allValidProducts
	{
		 get { } //Length: 300
	}

	public ProductCatalog() { }

	public void Add(ProductCatalogItem item) { }

	public static ProductCatalog Deserialize(string catalogJSON) { }

	public static ProductCatalog FromTextAsset(TextAsset asset) { }

	public ICollection<ProductCatalogItem> get_allProducts() { }

	public ICollection<ProductCatalogItem> get_allValidProducts() { }

	internal static void Initialize() { }

	public static void Initialize(IProductCatalogImpl productCatalogImpl) { }

	public bool IsEmpty() { }

	public static ProductCatalog LoadDefaultCatalog() { }

	public void Remove(ProductCatalogItem item) { }

	public static string Serialize(ProductCatalog catalog) { }

}

