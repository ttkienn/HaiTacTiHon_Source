namespace UnityEngine.Purchasing;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class AppleReceiptExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Comparison<AppleInAppPurchaseReceipt> <>9__1_1; //Field offset: 0x8
		[Nullable(0)]
		public static Func<AppleInAppPurchaseReceipt, Boolean> <>9__2_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal int <FindMostRecentReceiptForProduct>b__1_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

		[NullableContext(0)]
		internal bool <FirstNonCancelledReceipt>b__2_0(AppleInAppPurchaseReceipt receipt) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		[Nullable(0)]
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		[NullableContext(0)]
		internal bool <FindMostRecentReceiptForProduct>b__0(AppleInAppPurchaseReceipt r) { }

	}


	[Extension]
	public static AppleInAppPurchaseReceipt FindMostRecentReceiptForProduct(AppleReceipt appleReceipt, string productId) { }

	private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(IEnumerable<AppleInAppPurchaseReceipt> receipts) { }

	[Extension]
	[NullableContext(2)]
	public static bool HasInAppPurchaseReceipts(AppleReceipt appleReceipt) { }

	[Extension]
	private static bool IsCancelled(AppleInAppPurchaseReceipt receipt) { }

}

