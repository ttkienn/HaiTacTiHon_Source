namespace UnityEngine.UIElements;

public abstract class TreeViewController : BaseTreeViewController
{

	protected TreeView treeView
	{
		 get { } //Length: 130
	}

	protected TreeViewController() { }

	protected virtual void BindItem(VisualElement element, int index) { }

	protected virtual void DestroyItem(VisualElement element) { }

	protected TreeView get_treeView() { }

	protected virtual VisualElement MakeItem() { }

	protected virtual void UnbindItem(VisualElement element, int index) { }

}

