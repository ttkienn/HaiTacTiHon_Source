namespace UnityEngine.Purchasing;

internal class TransactionEventHelper
{
	private readonly IAnalyticsServiceWrapper m_Analytics; //Field offset: 0x10
	private readonly ILogger m_Logger; //Field offset: 0x18

	internal TransactionEventHelper(IAnalyticsServiceWrapper analytics, ILogger logger) { }

	internal long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product) { }

	private long ExtractRealCurrencyAmount(Product product) { }

}

