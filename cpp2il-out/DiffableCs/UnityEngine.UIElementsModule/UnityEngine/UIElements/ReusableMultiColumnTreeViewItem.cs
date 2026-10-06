namespace UnityEngine.UIElements;

internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
{

	public virtual VisualElement rootElement
	{
		 get { } //Length: 5
	}

	public ReusableMultiColumnTreeViewItem() { }

	public virtual VisualElement get_rootElement() { }

	public virtual void Init(VisualElement item) { }

	public void Init(VisualElement container, Columns columns) { }

}

