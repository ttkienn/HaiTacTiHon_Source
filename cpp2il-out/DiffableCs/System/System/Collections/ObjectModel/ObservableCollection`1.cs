namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
public class ObservableCollection : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
{
	private sealed class SimpleMonitor : IDisposable
	{
		internal int _busyCount; //Field offset: 0x0
		internal ObservableCollection<T> _collection; //Field offset: 0x0

		public SimpleMonitor(ObservableCollection<T> collection) { }

		public override void Dispose() { }

	}

	private SimpleMonitor<T> _monitor; //Field offset: 0x0
	private int _blockReentrancyCount; //Field offset: 0x0
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler CollectionChanged; //Field offset: 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x0

	public override event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected override event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private override event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	{
		private add { } //Length: 20
		private remove { } //Length: 20
	}

	public ObservableCollection`1() { }

	[CompilerGenerated]
	public override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CompilerGenerated]
	protected override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	protected void CheckReentrancy() { }

	protected virtual void ClearItems() { }

	private SimpleMonitor<T> EnsureMonitorInitialized() { }

	protected virtual void InsertItem(int index, T item) { }

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index) { }

	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index) { }

	private void OnCollectionReset() { }

	private void OnCountPropertyChanged() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	private void OnIndexerPropertyChanged() { }

	protected override void OnPropertyChanged(PropertyChangedEventArgs e) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	[CompilerGenerated]
	public override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CompilerGenerated]
	protected override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	protected virtual void RemoveItem(int index) { }

	protected virtual void SetItem(int index, T item) { }

	private override void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	private override void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

}

