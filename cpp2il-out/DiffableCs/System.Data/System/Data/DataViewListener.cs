namespace System.Data;

internal sealed class DataViewListener
{
	private readonly WeakReference _dvWeak; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x18
	private Index _index; //Field offset: 0x20
	internal readonly int _objectID; //Field offset: 0x28

	internal DataViewListener(DataView dv) { }

	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	private void CleanUp(bool updateListeners) { }

	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void IndexListChanged(ListChangedEventArgs e) { }

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void RegisterListChangedEvent(Index index) { }

	private void RegisterListener(DataTable table) { }

	internal void RegisterMetaDataEvents(DataTable table) { }

	internal void UnregisterListChangedEvent() { }

	internal void UnregisterMetaDataEvents() { }

	private void UnregisterMetaDataEvents(bool updateListeners) { }

}

