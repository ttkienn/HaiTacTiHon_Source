namespace UnityEngine.UIElements;

public class MultiColumnListViewController : BaseListViewController
{
	private MultiColumnController m_ColumnController; //Field offset: 0x48

	public MultiColumnController columnController
	{
		 get { } //Length: 5
	}

	internal MultiColumnCollectionHeader header
	{
		internal get { } //Length: 15
	}

	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	protected virtual void BindItem(VisualElement element, int index) { }

	protected virtual void DestroyItem(VisualElement element) { }

	public virtual void Dispose() { }

	public MultiColumnController get_columnController() { }

	internal MultiColumnCollectionHeader get_header() { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	protected virtual VisualElement MakeItem() { }

	protected virtual void PrepareView() { }

	protected virtual void UnbindItem(VisualElement element, int index) { }

	private void UpdateReorderClassList() { }

}

