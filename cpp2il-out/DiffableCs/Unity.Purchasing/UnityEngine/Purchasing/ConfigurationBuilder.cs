namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class ConfigurationBuilder
{
	private static ConfigurationBuilder instance; //Field offset: 0x0
	internal CatalogProvider m_CatalogProvider; //Field offset: 0x10
	internal ConfigurationProvider m_ConfigurationProvider; //Field offset: 0x18

	public ConfigurationBuilder() { }

	public void AddProduct(string id, ProductType type) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, PayoutDefinition payout) { }

	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts) { }

	public T Configure() { }

	public static ConfigurationBuilder Instance(object ignored) { }

}

