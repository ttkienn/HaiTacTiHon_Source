namespace UnityEngine.Purchasing;

internal class NativeStoreProvider : INativeStoreProvider
{

	public NativeStoreProvider() { }

	[NullableContext(1)]
	public override INativeAppleStore GetStorekit(IUnityCallback callback) { }

}

