namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductDetailsResponseListener : AndroidJavaProxy
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(0)]
		public AndroidJavaObject queryProductDetailsResult; //Field offset: 0x10
		[Nullable(0)]
		public ProductDetailsResponseListener <>4__this; //Field offset: 0x18
		[Nullable(0)]
		public AndroidJavaObject billingResult; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <onProductDetailsResponse>b__0() { }

	}

	private const string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener"; //Field offset: 0x0
	private readonly Action<IGoogleBillingResult, List`1<AndroidJavaObject>> m_OnProductDetailsResponse; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x30

	internal ProductDetailsResponseListener(Action<IGoogleBillingResult, List`1<AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	[Preserve]
	public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject queryProductDetailsResult) { }

}

