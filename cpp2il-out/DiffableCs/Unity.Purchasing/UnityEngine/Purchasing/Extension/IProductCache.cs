namespace UnityEngine.Purchasing.Extension;

[NullableContext(1)]
internal interface IProductCache
{

	public Dictionary<String, Product> productsById
	{
		 get { } //Length: 0
	}

	public void Add(Product product) { }

	public void Add(List<Product> product) { }

	[NullableContext(2)]
	public Product Find(string productId) { }

	public Product FindOrDefault(string productId) { }

	public Dictionary<String, Product> get_productsById() { }

	public ReadOnlyObservableCollection<Product> GetProducts() { }

	public void Remove(Product product) { }

}

