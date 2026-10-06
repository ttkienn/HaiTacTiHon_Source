namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IStoreFactory
{

	public IStoreWrapper CreateStore(string storeName) { }

	public void RegisterStore(string storeName, Func<IStoreWrapper> function) { }

}

