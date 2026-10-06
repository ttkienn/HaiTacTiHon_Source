namespace Unity.Services.Analytics;

public class TransactionVirtualCurrency
{
	private static readonly String[] k_VirtualCurrencyTypeValues; //Field offset: 0x0
	public string VirtualCurrencyName; //Field offset: 0x10
	public VirtualCurrencyType VirtualCurrencyType; //Field offset: 0x18
	public long VirtualCurrencyAmount; //Field offset: 0x20

	private static TransactionVirtualCurrency() { }

	public TransactionVirtualCurrency() { }

	internal void Serialize(IBuffer buffer) { }

}

