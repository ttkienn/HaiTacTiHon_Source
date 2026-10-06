namespace UnityEngine.Purchasing;

internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public GoogleAcknowledgePurchaseListener <>4__this; //Field offset: 0x10
		public AndroidJavaObject billingResult; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <onAcknowledgePurchaseResponse>b__0() { }

	}

	private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener"; //Field offset: 0x0
	private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28

	internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction, IUtil util) { }

	[Preserve]
	private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }

}

