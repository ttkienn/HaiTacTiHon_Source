namespace Unity.Services.Analytics;

internal class TransactionCurrencyConverter
{
	private readonly Dictionary<String, Int32> m_Iso4217CurrencyMinorUnits; //Field offset: 0x10

	public TransactionCurrencyConverter() { }

	public long Convert(string currencyCode, double value) { }

}

