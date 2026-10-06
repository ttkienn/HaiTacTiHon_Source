namespace UnityEngine.Purchasing;

internal class GooglePurchasesUpdatedListener : AndroidJavaProxy, IGooglePurchasesUpdatedListener
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public GooglePurchasesUpdatedListener <>4__this; //Field offset: 0x10
		public AndroidJavaObject billingResult; //Field offset: 0x18
		public AndroidJavaObject javaPurchasesList; //Field offset: 0x20

		public <>c__DisplayClass7_0() { }

		internal void <onPurchasesUpdated>b__0() { }

	}

	private const string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener"; //Field offset: 0x0
	[CompilerGenerated]
	private Action<IGoogleBillingResult, List`1<IGooglePurchase>> OnPurchaseUpdated; //Field offset: 0x20
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; //Field offset: 0x28
	private readonly IUtil m_Util; //Field offset: 0x30

	public override event Action<IGoogleBillingResult, List`1<IGooglePurchase>> OnPurchaseUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	internal GooglePurchasesUpdatedListener(IGooglePurchaseBuilder purchaseBuilder, IUtil util) { }

	[CompilerGenerated]
	public override void add_OnPurchaseUpdated(Action<IGoogleBillingResult, List`1<IGooglePurchase>> value) { }

	private void HandlePurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	[Preserve]
	public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseUpdated(Action<IGoogleBillingResult, List`1<IGooglePurchase>> value) { }

}

