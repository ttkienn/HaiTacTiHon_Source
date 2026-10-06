namespace UnityEngine.UIElements;

internal interface IVisualElementPanelActivatable
{

	public VisualElement element
	{
		 get { } //Length: 0
	}

	public bool CanBeActivated() { }

	public VisualElement get_element() { }

	public void OnPanelActivate() { }

	public void OnPanelDeactivate() { }

}

