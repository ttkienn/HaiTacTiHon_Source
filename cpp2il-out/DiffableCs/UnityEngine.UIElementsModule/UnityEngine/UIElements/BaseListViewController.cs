namespace UnityEngine.UIElements;

public abstract class BaseListViewController : CollectionViewController
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceSizeChanged; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x40

	public event Action<IEnumerable`1<Int32>> itemsAdded
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<IEnumerable`1<Int32>> itemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action itemsSourceSizeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected BaseListView baseListView
	{
		 get { } //Length: 130
	}

	protected BaseListViewController() { }

	[CompilerGenerated]
	internal static bool <AddItems>g__IsGenericList|15_0(Type t) { }

	[CompilerGenerated]
	public void add_itemsAdded(Action<IEnumerable`1<Int32>> value) { }

	[CompilerGenerated]
	public void add_itemsRemoved(Action<IEnumerable`1<Int32>> value) { }

	[CompilerGenerated]
	public void add_itemsSourceSizeChanged(Action value) { }

	public override void AddItems(int itemCount) { }

	private static Array AddToArray(Array source, int itemCount) { }

	public override void ClearItems() { }

	private void EnsureItemSourceCanBeResized() { }

	protected BaseListView get_baseListView() { }

	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	public override void Move(int index, int newIndex) { }

	public override bool NeedsDragHandle(int index) { }

	internal void PostInitRegistration(ReusableListViewItem listItem) { }

	protected void RaiseItemsAdded(IEnumerable<Int32> indices) { }

	protected void RaiseItemsRemoved(IEnumerable<Int32> indices) { }

	protected void RaiseOnSizeChanged() { }

	[CompilerGenerated]
	public void remove_itemsAdded(Action<IEnumerable`1<Int32>> value) { }

	[CompilerGenerated]
	public void remove_itemsRemoved(Action<IEnumerable`1<Int32>> value) { }

	[CompilerGenerated]
	public void remove_itemsSourceSizeChanged(Action value) { }

	private static Array RemoveFromArray(Array source, List<Int32> indicesToRemove) { }

	public override void RemoveItem(int index) { }

	public override void RemoveItems(List<Int32> indices) { }

	internal override void RemoveItems(int itemCount) { }

	private void Swap(int lhs, int rhs) { }

}

