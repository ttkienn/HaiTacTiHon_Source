namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
public class ReadOnlyObservableCollection : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
{
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler CollectionChanged; //Field offset: 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x0

	protected override event NotifyCollectionChangedEventHandler CollectionChanged
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

	private override event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged
	{
		private add { } //Length: 20
		private remove { } //Length: 20
	}

	private override event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	{
		private add { } //Length: 20
		private remove { } //Length: 20
	}

	public ReadOnlyObservableCollection`1(ObservableCollection<T> list) { }

	[CompilerGenerated]
	protected override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CompilerGenerated]
	protected override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }

	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }

	protected override void OnPropertyChanged(PropertyChangedEventArgs args) { }

	[CompilerGenerated]
	protected override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CompilerGenerated]
	protected override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	private override void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	private override void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	private override void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	private override void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

}

