namespace UnityEngine.UIElements;

internal class ReusableMultiColumnListViewItem : ReusableListViewItem
{

	public virtual VisualElement rootElement
	{
		 get { } //Length: 5
	}

	public ReusableMultiColumnListViewItem() { }

	public virtual VisualElement get_rootElement() { }

	public virtual void Init(VisualElement item) { }

	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

}

