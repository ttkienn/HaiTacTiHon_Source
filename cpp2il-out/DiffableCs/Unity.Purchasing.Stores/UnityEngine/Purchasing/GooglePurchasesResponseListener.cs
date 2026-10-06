namespace UnityEngine.Purchasing;

internal class GooglePurchasesResponseListener : AndroidJavaProxy
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public AndroidJavaObject purchases; //Field offset: 0x10
		public GooglePurchasesResponseListener <>4__this; //Field offset: 0x18
		public AndroidJavaObject billingResult; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <onQueryPurchasesResponse>b__0() { }

	}

	private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener"; //Field offset: 0x0
	private readonly Action<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> m_OnQueryPurchasesResponse; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28

	internal GooglePurchasesResponseListener(Action<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> onQueryPurchasesResponse, IUtil util) { }

	[Preserve]
	public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases) { }

}

