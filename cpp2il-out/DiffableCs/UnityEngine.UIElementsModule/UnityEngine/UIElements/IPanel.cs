namespace UnityEngine.UIElements;

public interface IPanel : IDisposable
{

	public ContextType contextType
	{
		 get { } //Length: 0
	}

	public EventDispatcher dispatcher
	{
		 get { } //Length: 0
	}

	public FocusController focusController
	{
		 get { } //Length: 0
	}

	public VisualElement visualTree
	{
		 get { } //Length: 0
	}

	public ContextType get_contextType() { }

	public EventDispatcher get_dispatcher() { }

	public FocusController get_focusController() { }

	public VisualElement get_visualTree() { }

	public VisualElement Pick(Vector2 point) { }

}

