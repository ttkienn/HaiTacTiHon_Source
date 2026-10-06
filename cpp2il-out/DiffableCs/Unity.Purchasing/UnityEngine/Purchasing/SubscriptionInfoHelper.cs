namespace UnityEngine.Purchasing;

public class SubscriptionInfoHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<AppleInAppPurchaseReceipt> <>9__7_0; //Field offset: 0x8
		public static Func<Object, String> <>9__8_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <FindMostRecentReceipt>b__7_0(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

		internal string <GetGooglePlayStoreSubInfo>b__8_0(object obj) { }

	}

	private readonly string m_Receipt; //Field offset: 0x10
	private readonly string m_ProductId; //Field offset: 0x18
	private readonly string m_IntroJson; //Field offset: 0x20

	public SubscriptionInfoHelper(Product product, string introJson) { }

	public SubscriptionInfoHelper(string receipt, string id, string introJson) { }

	private static AppleInAppPurchaseReceipt FindMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts) { }

	private SubscriptionInfo GetAppleAppStoreSubInfo(string payload, string productId) { }

	private static SubscriptionInfo GetGooglePlayStoreSubInfo(string payload) { }

	public SubscriptionInfo GetSubscriptionInfo() { }

}

