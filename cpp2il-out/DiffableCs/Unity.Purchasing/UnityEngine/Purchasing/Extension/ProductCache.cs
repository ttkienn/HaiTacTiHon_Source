namespace UnityEngine.Purchasing.Extension;

[Nullable(0)]
[NullableContext(1)]
internal class ProductCache : IProductCache
{
	private ObservableCollection<Product> m_Products; //Field offset: 0x10
	private readonly ReadOnlyObservableCollection<Product> m_ProductsReadOnly; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary<String, Product> <productsById>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Dictionary<String, Product> <productsByStoreSpecificId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Dictionary<String, String> <storeSpecificProductIds>k__BackingField; //Field offset: 0x30

	public override Dictionary<String, Product> productsById
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private Dictionary<String, Product> productsByStoreSpecificId
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	private Dictionary<String, String> storeSpecificProductIds
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	internal ProductCache() { }

	public override void Add(List<Product> products) { }

	public override void Add(Product product) { }

	[NullableContext(2)]
	public override Product Find(string productId) { }

	public override Product FindOrDefault(string productId) { }

	[CompilerGenerated]
	public override Dictionary<String, Product> get_productsById() { }

	[CompilerGenerated]
	private Dictionary<String, Product> get_productsByStoreSpecificId() { }

	[CompilerGenerated]
	private Dictionary<String, String> get_storeSpecificProductIds() { }

	public override ReadOnlyObservableCollection<Product> GetProducts() { }

	[NullableContext(2)]
	private bool HasId(string productId) { }

	[NullableContext(2)]
	private bool HasStoreSpecificId(string productId) { }

	public override void Remove(Product product) { }

}

