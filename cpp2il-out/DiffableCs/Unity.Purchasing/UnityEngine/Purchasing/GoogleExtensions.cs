namespace UnityEngine.Purchasing;

internal class GoogleExtensions : IGooglePlayStoreExtensions, IStoreExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Order, Boolean> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <IsPurchasedProductDeferred>b__5_0(Order order) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string oldSku; //Field offset: 0x10
		public string newSku; //Field offset: 0x18
		public Func<CartItem, Boolean> <>9__1; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal bool <UpgradeDowngradeSubscription>b__0(Product product) { }

		internal bool <UpgradeDowngradeSubscription>b__1(CartItem cartItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Product product; //Field offset: 0x10
		public Func<CartItem, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <IsPurchasedProductDeferred>b__1(CartItem cartItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Product product; //Field offset: 0x10
		public Func<CartItem, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal bool <GetPurchaseState>b__0(CartItem cartItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Product product; //Field offset: 0x10
		public Func<CartItem, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal bool <GetObfuscatedAccountId>b__0(CartItem cartItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Product product; //Field offset: 0x10
		public Func<CartItem, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal bool <GetObfuscatedProfileId>b__0(CartItem cartItem) { }

	}


	public GoogleExtensions() { }

	public override void ConfirmSubscriptionPriceChange(string productId, Action<Boolean> callback) { }

	public override string GetObfuscatedAccountId(Product product) { }

	public override string GetObfuscatedProfileId(Product product) { }

	public override GooglePurchaseState GetPurchaseState(Product product) { }

	public override bool IsPurchasedProductDeferred(Product product) { }

	public override void RestoreTransactions(Action<Boolean, String> callback) { }

	public override void UpgradeDowngradeSubscription(string oldSku, string newSku) { }

	public override void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode) { }

	public override void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode) { }

}

