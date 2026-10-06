namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class CatalogProvider : ICatalogProvider, IBaseCatalogProvider
{
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1, 1, 1}])]
	private Dictionary<String, Dictionary`2<String, String>> m_StoreSpecificIds; //Field offset: 0x10
	private List<ProductDefinition> m_Products; //Field offset: 0x18

	public CatalogProvider() { }

	public override void AddProduct(string id, ProductType type) { }

	public override void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs) { }

	public override void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, PayoutDefinition payout) { }

	public override void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts) { }

	public override void AddProducts(IEnumerable<ProductDefinition> productsDefinitions, Dictionary<String, StoreSpecificIds> storeIDsByProductId) { }

	private string AddStoreSpecificIds(string id, StoreSpecificIds storeIDs) { }

	public override void FetchProducts(Action<List`1<ProductDefinition>> callback) { }

	public override void FetchProducts(Action<List`1<ProductDefinition>> callback, string storeName) { }

	public override List<ProductDefinition> GetProducts(string storeName = null) { }

	private void UpdateStoreSpecificIDs(string storeName) { }

}

