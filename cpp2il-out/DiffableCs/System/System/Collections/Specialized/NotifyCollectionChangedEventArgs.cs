namespace System.Collections.Specialized;

public class NotifyCollectionChangedEventArgs : EventArgs
{
	private NotifyCollectionChangedAction _action; //Field offset: 0x10
	private IList _newItems; //Field offset: 0x18
	private IList _oldItems; //Field offset: 0x20
	private int _newStartingIndex; //Field offset: 0x28
	private int _oldStartingIndex; //Field offset: 0x2C

	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action) { }

	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index) { }

	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

}

