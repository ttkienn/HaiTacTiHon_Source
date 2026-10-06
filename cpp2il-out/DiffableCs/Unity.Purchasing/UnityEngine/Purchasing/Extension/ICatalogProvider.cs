namespace UnityEngine.Purchasing.Extension;

[NullableContext(1)]
public interface ICatalogProvider : IBaseCatalogProvider
{

	public void AddProduct(string id, ProductType type) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, PayoutDefinition payout) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts) { }

	public void AddProducts(IEnumerable<ProductDefinition> products, Dictionary<String, StoreSpecificIds> storeIDsByProductId = null) { }

	public void FetchProducts(Action<List`1<ProductDefinition>> callback, string storeName) { }

	public List<ProductDefinition> GetProducts(string storeName = null) { }

}

