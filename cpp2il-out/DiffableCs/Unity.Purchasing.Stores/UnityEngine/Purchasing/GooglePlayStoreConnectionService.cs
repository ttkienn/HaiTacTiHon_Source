namespace UnityEngine.Purchasing;

internal class GooglePlayStoreConnectionService : IGooglePlayStoreConnectionService
{
	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10
	private readonly IBillingClientStateListener m_BillingClientStateListener; //Field offset: 0x18
	private IStoreConnectCallback m_ConnectCallback; //Field offset: 0x20

	[Preserve]
	public GooglePlayStoreConnectionService(IGoogleBillingClient billingClient, IBillingClientStateListener billingClientStateListener) { }

	public override GoogleBillingConnectionState CheckConnectionState() { }

	public override void Connect() { }

	public override bool IsReady() { }

	private void OnConnected() { }

	private void OnDisconnected(GoogleBillingResponseCode responseCode) { }

	public override void SetConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

}

