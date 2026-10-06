namespace Unity.Services.Analytics;

public class TransactionRealCurrency
{
	public string RealCurrencyType; //Field offset: 0x10
	public long RealCurrencyAmount; //Field offset: 0x18

	public TransactionRealCurrency() { }

	internal void Serialize(IBuffer buffer) { }

}

