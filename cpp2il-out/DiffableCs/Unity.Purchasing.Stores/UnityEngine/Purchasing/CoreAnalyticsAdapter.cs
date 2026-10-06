namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class CoreAnalyticsAdapter : IAnalyticsAdapter
{
	private const string k_TransactionEventName = "transaction"; //Field offset: 0x0
	private const string k_TransactionFailedEventName = "transactionFailed"; //Field offset: 0x0
	private const string k_PurchasingPackageName = "com.unity.purchasing"; //Field offset: 0x0
	private const int k_TransactionEventVersion = 1; //Field offset: 0x0
	private const int k_TransactionFailedEventVersion = 1; //Field offset: 0x0
	private readonly ILogger m_Logger; //Field offset: 0x10
	[Nullable(2)]
	private IAnalyticsStandardEventComponent m_CoreAnalytics; //Field offset: 0x18
	private TransactionEventHelper m_TransactionEventHelper; //Field offset: 0x20

	[Preserve]
	internal CoreAnalyticsAdapter(IAnalyticsServiceWrapper analytics, ILogger logger) { }

	private Dictionary<String, Object> BuildTransactionFailedParameters(CartItem item, string failureReason) { }

	private Dictionary<String, Object> BuildTransactionParameters(CartItem item, string receipt) { }

	[NullableContext(2)]
	private IAnalyticsStandardEventComponent CoreAnalyticsComponent() { }

	private Dictionary<String, Object> CreateRealCurrencyFromProduct(Product product) { }

	private static Dictionary<String, Object> GenerateItemReceivedForPurchase(CartItem item) { }

	private Dictionary<String, Object> GenerateRealCurrencySpentOnPurchase(Product product) { }

	public override void SendTransactionEvent(CartItem item, string receipt) { }

	public override void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription) { }

}

