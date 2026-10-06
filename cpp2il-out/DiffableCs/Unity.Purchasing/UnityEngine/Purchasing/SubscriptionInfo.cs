namespace UnityEngine.Purchasing;

public class SubscriptionInfo
{
	private readonly Result m_IsSubscribed; //Field offset: 0x10
	private readonly Result m_IsExpired; //Field offset: 0x14
	private readonly Result m_IsCancelled; //Field offset: 0x18
	private readonly Result m_IsFreeTrial; //Field offset: 0x1C
	private readonly Result m_IsAutoRenewing; //Field offset: 0x20
	private readonly Result m_IsIntroductoryPricePeriod; //Field offset: 0x24
	private readonly string m_ProductId; //Field offset: 0x28
	private readonly DateTime m_PurchaseDate; //Field offset: 0x30
	private readonly DateTime m_SubscriptionExpireDate; //Field offset: 0x38
	private readonly DateTime m_SubscriptionCancelDate; //Field offset: 0x40
	private readonly TimeSpan m_RemainedTime; //Field offset: 0x48
	private readonly string m_IntroductoryPrice; //Field offset: 0x50
	private readonly TimeSpan m_IntroductoryPricePeriod; //Field offset: 0x58
	private readonly long m_IntroductoryPriceCycles; //Field offset: 0x60
	private readonly TimeSpan m_FreeTrialPeriod; //Field offset: 0x68
	private readonly TimeSpan m_SubscriptionPeriod; //Field offset: 0x70
	private readonly string m_FreeTrialPeriodString; //Field offset: 0x78
	private readonly string m_SKUDetails; //Field offset: 0x80

	public SubscriptionInfo(AppleInAppPurchaseReceipt r, string introJson) { }

	public SubscriptionInfo(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata) { }

	public SubscriptionInfo(string productId) { }

	private static TimeSpan AccumulateIntroductoryDuration(TimeSpanUnits units, long cycles) { }

	private static double ComputeExtraTime(string metadata, double newSKUPeriodInSeconds) { }

	private static TimeSpan ComputePeriodTimeSpan(TimeSpanUnits units) { }

	[Obsolete("getCancelDate is deprecated. Please use GetCancelDate instead.", False)]
	public DateTime getCancelDate() { }

	public DateTime GetCancelDate() { }

	[Obsolete("getExpireDate is deprecated. Please use GetExpireDate instead.", False)]
	public DateTime getExpireDate() { }

	public DateTime GetExpireDate() { }

	[Obsolete("getFreeTrialPeriod is deprecated. Please use GetFreeTrialPeriod instead.", False)]
	public TimeSpan getFreeTrialPeriod() { }

	public TimeSpan GetFreeTrialPeriod() { }

	[Obsolete("getFreeTrialPeriodString is deprecated. Please use GetFreeTrialPeriodString instead.", False)]
	public string getFreeTrialPeriodString() { }

	public string GetFreeTrialPeriodString() { }

	[Obsolete("getIntroductoryPrice is deprecated. Please use GetIntroductoryPrice instead.", False)]
	public string getIntroductoryPrice() { }

	public string GetIntroductoryPrice() { }

	[Obsolete("getIntroductoryPricePeriod is deprecated. Please use GetIntroductoryPricePeriod instead.", False)]
	public TimeSpan getIntroductoryPricePeriod() { }

	public TimeSpan GetIntroductoryPricePeriod() { }

	[Obsolete("getIntroductoryPricePeriodCycles is deprecated. Please use GetIntroductoryPricePeriodCycles instead.", False)]
	public long getIntroductoryPricePeriodCycles() { }

	public long GetIntroductoryPricePeriodCycles() { }

	[Obsolete("getProductId is deprecated. Please use GetProductId instead.", False)]
	public string getProductId() { }

	public string GetProductId() { }

	[Obsolete("getPurchaseDate is deprecated. Please use GetPurchaseDate instead.", False)]
	public DateTime getPurchaseDate() { }

	public DateTime GetPurchaseDate() { }

	[Obsolete("getRemainingTime is deprecated. Please use GetRemainingTime instead.", False)]
	public TimeSpan getRemainingTime() { }

	public TimeSpan GetRemainingTime() { }

	[Obsolete("getSkuDetails is deprecated. Please use GetSkuDetails instead.", False)]
	public string getSkuDetails() { }

	public string GetSkuDetails() { }

	[Obsolete("getSubscriptionInfoJsonString is deprecated. Please use GetSubscriptionInfoJsonString instead.", False)]
	public string getSubscriptionInfoJsonString() { }

	public string GetSubscriptionInfoJsonString() { }

	[Obsolete("getSubscriptionPeriod is deprecated. Please use GetSubscriptionPeriod instead.", False)]
	public TimeSpan getSubscriptionPeriod() { }

	public TimeSpan GetSubscriptionPeriod() { }

	[Obsolete("isAutoRenewing is deprecated. Please use IsAutoRenewing instead.", False)]
	public Result isAutoRenewing() { }

	public Result IsAutoRenewing() { }

	[Obsolete("isCancelled is deprecated. Please use IsCancelled instead.", False)]
	public Result isCancelled() { }

	public Result IsCancelled() { }

	[Obsolete("isExpired is deprecated. Please use IsExpired instead.", False)]
	public Result isExpired() { }

	public Result IsExpired() { }

	[Obsolete("isFreeTrial is deprecated. Please use IsFreeTrial instead.", False)]
	public Result isFreeTrial() { }

	public Result IsFreeTrial() { }

	[Obsolete("isIntroductoryPricePeriod is deprecated. Please use IsIntroductoryPricePeriod instead.", False)]
	public Result isIntroductoryPricePeriod() { }

	public Result IsIntroductoryPricePeriod() { }

	[Obsolete("isSubscribed is deprecated. Please use IsSubscribed instead.", False)]
	public Result isSubscribed() { }

	public Result IsSubscribed() { }

	private static DateTime NextBillingDate(DateTime billingBeginDate, TimeSpanUnits units) { }

	private static TimeSpanUnits ParsePeriodTimeSpanUnits(string timeSpan) { }

	private static TimeSpan ParseTimeSpan(string periodString) { }

}

