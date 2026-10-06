namespace UnityEngine.Purchasing;

public class ProductCatalogItem
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string aStore; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <SetStoreID>b__0(StoreID obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public string store; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetStoreID>b__0(StoreID obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public StoreID storeId; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <SetStoreIDs>b__0(StoreID obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public TranslationLocale locale; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <GetDescription>b__0(LocalizedProductDescription obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public TranslationLocale locale; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <RemoveDescription>b__0(LocalizedProductDescription obj) { }

	}

	public string id; //Field offset: 0x10
	public ProductType type; //Field offset: 0x18
	[SerializeField]
	private List<StoreID> storeIDs; //Field offset: 0x20
	public LocalizedProductDescription defaultDescription; //Field offset: 0x28
	public string screenshotPath; //Field offset: 0x30
	public int applePriceTier; //Field offset: 0x38
	public Price googlePrice; //Field offset: 0x40
	public string pricingTemplateID; //Field offset: 0x48
	[SerializeField]
	private List<LocalizedProductDescription> descriptions; //Field offset: 0x50
	[SerializeField]
	private List<ProductCatalogPayout> payouts; //Field offset: 0x58

	public ICollection<StoreID> allStoreIDs
	{
		 get { } //Length: 5
	}

	public bool HasAvailableLocale
	{
		 get { } //Length: 199
	}

	public TranslationLocale NextAvailableLocale
	{
		 get { } //Length: 568
	}

	public IList<ProductCatalogPayout> Payouts
	{
		 get { } //Length: 5
	}

	public ICollection<LocalizedProductDescription> translatedDescriptions
	{
		 get { } //Length: 5
	}

	public ProductCatalogItem() { }

	public LocalizedProductDescription AddDescription(TranslationLocale locale) { }

	public void AddPayout() { }

	public ProductCatalogItem Clone() { }

	public ICollection<StoreID> get_allStoreIDs() { }

	public bool get_HasAvailableLocale() { }

	public TranslationLocale get_NextAvailableLocale() { }

	public IList<ProductCatalogPayout> get_Payouts() { }

	public ICollection<LocalizedProductDescription> get_translatedDescriptions() { }

	public LocalizedProductDescription GetDescription(TranslationLocale locale) { }

	public LocalizedProductDescription GetOrCreateDescription(TranslationLocale locale) { }

	public string GetStoreID(string store) { }

	public void RemoveDescription(TranslationLocale locale) { }

	public void RemovePayout(ProductCatalogPayout payout) { }

	public void SetStoreID(string aStore, string aId) { }

	public void SetStoreIDs(ICollection<StoreID> storeIds) { }

}

