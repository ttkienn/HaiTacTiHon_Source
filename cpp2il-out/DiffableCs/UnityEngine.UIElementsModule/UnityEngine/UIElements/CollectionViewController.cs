namespace UnityEngine.UIElements;

public abstract class CollectionViewController : IDisposable
{
	private BaseVerticalCollectionView m_View; //Field offset: 0x10
	private IList m_ItemsSource; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x28

	public event Action<Int32, Int32> itemIndexChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action itemsSourceChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override IList itemsSource
	{
		 get { } //Length: 5
		 set { } //Length: 162
	}

	protected BaseVerticalCollectionView view
	{
		 get { } //Length: 5
	}

	protected CollectionViewController() { }

	[CompilerGenerated]
	public void add_itemIndexChanged(Action<Int32, Int32> value) { }

	[CompilerGenerated]
	public void add_itemsSourceChanged(Action value) { }

	protected abstract void BindItem(VisualElement element, int index) { }

	protected abstract void DestroyItem(VisualElement element) { }

	public override void Dispose() { }

	public override IList get_itemsSource() { }

	protected BaseVerticalCollectionView get_view() { }

	public override int GetIdForIndex(int index) { }

	public override int GetIndexForId(int id) { }

	public override object GetItemForIndex(int index) { }

	public override int GetItemsCount() { }

	internal override int GetItemsMinCount() { }

	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	internal override void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	protected abstract VisualElement MakeItem() { }

	protected override void PrepareView() { }

	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	protected void RaiseItemsSourceChanged() { }

	[CompilerGenerated]
	public void remove_itemIndexChanged(Action<Int32, Int32> value) { }

	[CompilerGenerated]
	public void remove_itemsSourceChanged(Action value) { }

	public override void set_itemsSource(IList value) { }

	protected void SetItemsSourceWithoutNotify(IList source) { }

	public void SetView(BaseVerticalCollectionView collectionView) { }

	protected abstract void UnbindItem(VisualElement element, int index) { }

}

