namespace UnityEngine.UIElements;

public class ListViewController : BaseListViewController
{

	protected ListView listView
	{
		 get { } //Length: 130
	}

	public ListViewController() { }

	protected virtual void BindItem(VisualElement element, int index) { }

	protected virtual void DestroyItem(VisualElement element) { }

	protected ListView get_listView() { }

	protected virtual VisualElement MakeItem() { }

	protected virtual void UnbindItem(VisualElement element, int index) { }

}

