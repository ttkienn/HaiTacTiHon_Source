namespace UnityEngine.Purchasing;

internal sealed class StorefrontChangeCallback : MulticastDelegate
{

	public StorefrontChangeCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(string storefrontCountryCode, string storefrontId, AsyncCallback callback, object object) { }

	public override bool EndInvoke(IAsyncResult result) { }

	public override bool Invoke(string storefrontCountryCode, string storefrontId) { }

}

