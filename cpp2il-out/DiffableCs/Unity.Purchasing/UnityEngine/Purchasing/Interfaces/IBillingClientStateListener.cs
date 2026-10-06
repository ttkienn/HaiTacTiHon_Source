namespace UnityEngine.Purchasing.Interfaces;

internal interface IBillingClientStateListener
{

	public void RegisterOnConnected(Action onConnected) { }

	public void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected) { }

}

