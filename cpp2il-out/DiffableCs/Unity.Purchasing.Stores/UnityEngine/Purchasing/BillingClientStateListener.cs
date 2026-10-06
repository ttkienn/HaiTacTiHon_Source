namespace UnityEngine.Purchasing;

internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public BillingClientStateListener <>4__this; //Field offset: 0x10
		public AndroidJavaObject billingResult; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <onBillingSetupFinished>b__0() { }

	}

	private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener"; //Field offset: 0x0
	private Action m_OnConnected; //Field offset: 0x20
	private Action<GoogleBillingResponseCode> m_Disconnect; //Field offset: 0x28
	private readonly IUtil m_Util; //Field offset: 0x30

	internal BillingClientStateListener(IUtil util) { }

	[CompilerGenerated]
	private void <onBillingServiceDisconnected>b__9_0() { }

	private void HandleBillingSetupFinished(AndroidJavaObject billingResult) { }

	[Preserve]
	public void onBillingServiceDisconnected() { }

	[Preserve]
	public void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	public override void RegisterOnConnected(Action onConnected) { }

	public override void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected) { }

}

