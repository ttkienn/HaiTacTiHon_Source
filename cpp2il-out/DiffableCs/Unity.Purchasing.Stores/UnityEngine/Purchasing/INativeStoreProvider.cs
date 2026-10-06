namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface INativeStoreProvider
{

	public INativeAppleStore GetStorekit(IUnityCallback callback) { }

}

