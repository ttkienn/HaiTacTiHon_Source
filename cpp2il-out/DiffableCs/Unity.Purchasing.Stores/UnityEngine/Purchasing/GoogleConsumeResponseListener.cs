namespace UnityEngine.Purchasing;

internal class GoogleConsumeResponseListener : AndroidJavaProxy
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public GoogleConsumeResponseListener <>4__this; //Field offset: 0x10
		public AndroidJavaObject billingResult; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <onConsumeResponse>b__0() { }

	}

	private const string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener"; //Field offset: 0x0
	private readonly Action<IGoogleBillingResult> m_OnConsumeResponse; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28

	internal GoogleConsumeResponseListener(Action<IGoogleBillingResult> onConsumeResponseAction, IUtil util) { }

	[Preserve]
	private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }

}

