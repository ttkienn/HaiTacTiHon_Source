namespace UnityEngine.Purchasing;

internal class AppleConfiguration : IAppleConfiguration, IStoreConfiguration
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action<List`1<Product>> callback; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		[NullableContext(1)]
		internal void <SetEntitlementsRevokedListener>b__0(string productIds) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public string productIds; //Field offset: 0x10

		public <>c__DisplayClass5_1() { }

		internal bool <SetEntitlementsRevokedListener>b__1(Product product) { }

	}


	public override string appReceipt
	{
		 get { } //Length: 112
	}

	public override bool canMakePayments
	{
		 get { } //Length: 162
	}

	public AppleConfiguration() { }

	public override string get_appReceipt() { }

	public override bool get_canMakePayments() { }

	public override void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback) { }

	public override void SetEntitlementsRevokedListener(Action<List`1<Product>> callback) { }

}

