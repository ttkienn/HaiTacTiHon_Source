namespace Unity.Services.Analytics;

public class TransactionEvent : Event
{
	private static readonly String[] k_TransactionTypeValues; //Field offset: 0x0
	private static readonly String[] k_TransactionServerValues; //Field offset: 0x8
	[CompilerGenerated]
	private TransactionRealCurrency <SpentRealCurrency>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private List<TransactionVirtualCurrency> <SpentVirtualCurrencies>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private List<TransactionItem> <SpentItems>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private TransactionRealCurrency <ReceivedRealCurrency>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private List<TransactionVirtualCurrency> <ReceivedVirtualCurrencies>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private List<TransactionItem> <ReceivedItems>k__BackingField; //Field offset: 0x68

	public string PaymentCountry
	{
		 set { } //Length: 131
	}

	public string ProductId
	{
		 set { } //Length: 131
	}

	public private List<TransactionItem> ReceivedItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public TransactionRealCurrency ReceivedRealCurrency
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public private List<TransactionVirtualCurrency> ReceivedVirtualCurrencies
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private List<TransactionItem> SpentItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public TransactionRealCurrency SpentRealCurrency
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public private List<TransactionVirtualCurrency> SpentVirtualCurrencies
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public string StoreId
	{
		 set { } //Length: 131
	}

	public string StoreItemId
	{
		 set { } //Length: 131
	}

	public string StoreItemSkuId
	{
		 set { } //Length: 131
	}

	public string StoreSourceId
	{
		 set { } //Length: 131
	}

	public string TransactionId
	{
		 set { } //Length: 131
	}

	public string TransactionName
	{
		 set { } //Length: 131
	}

	public string TransactionReceipt
	{
		 set { } //Length: 131
	}

	public string TransactionReceiptSignature
	{
		 set { } //Length: 131
	}

	public TransactionServer TransactionServer
	{
		 set { } //Length: 206
	}

	public TransactionType TransactionType
	{
		 set { } //Length: 205
	}

	public string TransactorID
	{
		 set { } //Length: 131
	}

	private static TransactionEvent() { }

	public TransactionEvent() { }

	protected private TransactionEvent(string name) { }

	[CompilerGenerated]
	public List<TransactionItem> get_ReceivedItems() { }

	[CompilerGenerated]
	public TransactionRealCurrency get_ReceivedRealCurrency() { }

	[CompilerGenerated]
	public List<TransactionVirtualCurrency> get_ReceivedVirtualCurrencies() { }

	[CompilerGenerated]
	public List<TransactionItem> get_SpentItems() { }

	[CompilerGenerated]
	public TransactionRealCurrency get_SpentRealCurrency() { }

	[CompilerGenerated]
	public List<TransactionVirtualCurrency> get_SpentVirtualCurrencies() { }

	public virtual void Reset() { }

	internal virtual void Serialize(IBuffer buffer) { }

	public void set_PaymentCountry(string value) { }

	public void set_ProductId(string value) { }

	[CompilerGenerated]
	private void set_ReceivedItems(List<TransactionItem> value) { }

	[CompilerGenerated]
	public void set_ReceivedRealCurrency(TransactionRealCurrency value) { }

	[CompilerGenerated]
	private void set_ReceivedVirtualCurrencies(List<TransactionVirtualCurrency> value) { }

	[CompilerGenerated]
	private void set_SpentItems(List<TransactionItem> value) { }

	[CompilerGenerated]
	public void set_SpentRealCurrency(TransactionRealCurrency value) { }

	[CompilerGenerated]
	private void set_SpentVirtualCurrencies(List<TransactionVirtualCurrency> value) { }

	public void set_StoreId(string value) { }

	public void set_StoreItemId(string value) { }

	public void set_StoreItemSkuId(string value) { }

	public void set_StoreSourceId(string value) { }

	public void set_TransactionId(string value) { }

	public void set_TransactionName(string value) { }

	public void set_TransactionReceipt(string value) { }

	public void set_TransactionReceiptSignature(string value) { }

	public void set_TransactionServer(TransactionServer value) { }

	public void set_TransactionType(TransactionType value) { }

	public void set_TransactorID(string value) { }

	public virtual void Validate() { }

}

