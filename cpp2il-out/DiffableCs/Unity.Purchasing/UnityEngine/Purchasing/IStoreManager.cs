namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IStoreManager
{

	public IStoreWrapper GetStore(string name) { }

}

