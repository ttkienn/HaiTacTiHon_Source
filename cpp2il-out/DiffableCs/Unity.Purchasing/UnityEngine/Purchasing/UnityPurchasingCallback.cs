namespace UnityEngine.Purchasing;

internal sealed class UnityPurchasingCallback : MulticastDelegate
{

	public UnityPurchasingCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }

}

