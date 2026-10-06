namespace UnityEngine.Purchasing;

public class ProductDefinition
{
	[CompilerGenerated]
	private string <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ProductType <type>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <enabled>k__BackingField; //Field offset: 0x24
	private readonly List<PayoutDefinition> m_Payouts; //Field offset: 0x28

	public private bool enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public PayoutDefinition payout
	{
		 get { } //Length: 99
	}

	public IEnumerable<PayoutDefinition> payouts
	{
		 get { } //Length: 5
	}

	public internal string storeSpecificId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public private ProductType type
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private ProductDefinition() { }

	public ProductDefinition(string id, string storeSpecificId, ProductType type) { }

	public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled) { }

	public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, PayoutDefinition payout) { }

	public ProductDefinition(string id, ProductType type, bool enabled, PayoutDefinition payout) { }

	public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts) { }

	public ProductDefinition(string id, ProductType type) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_enabled() { }

	[CompilerGenerated]
	public string get_id() { }

	public PayoutDefinition get_payout() { }

	public IEnumerable<PayoutDefinition> get_payouts() { }

	[CompilerGenerated]
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	public ProductType get_type() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_enabled(bool value) { }

	[CompilerGenerated]
	private void set_id(string value) { }

	[CompilerGenerated]
	internal void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	private void set_type(ProductType value) { }

	internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts) { }

	public virtual string ToString() { }

}

