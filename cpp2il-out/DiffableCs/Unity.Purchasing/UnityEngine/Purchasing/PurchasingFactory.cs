namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
internal class PurchasingFactory
{
	private IStore m_Store; //Field offset: 0x10
	private IBaseCatalogProvider m_CatalogProvider; //Field offset: 0x18
	[CompilerGenerated]
	private string <storeName>k__BackingField; //Field offset: 0x20

	public IStore service
	{
		 get { } //Length: 102
		 set { } //Length: 13
	}

	public private string storeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public PurchasingFactory() { }

	public IStore get_service() { }

	[CompilerGenerated]
	public string get_storeName() { }

	internal IBaseCatalogProvider GetCatalogProvider() { }

	public void RegisterStore(string name, Store s) { }

	public void set_service(IStore value) { }

	[CompilerGenerated]
	private void set_storeName(string value) { }

	public void SetCatalogProvider(IBaseCatalogProvider provider) { }

	public void SetCatalogProviderFunction(Action<Action`1<List`1<ProductDefinition>>> func) { }

}

