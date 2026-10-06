namespace Purchasing.Extension;

internal abstract class InternalStore : Store, IInternalStore, IStore
{
	internal IStoreConnectionStateService StoreConnectionStateService; //Field offset: 0x50

	protected InternalStore() { }

	public override ConnectionState GetStoreConnectionState() { }

	public override void SetStoreConnectionState(ConnectionState connectionState) { }

}

