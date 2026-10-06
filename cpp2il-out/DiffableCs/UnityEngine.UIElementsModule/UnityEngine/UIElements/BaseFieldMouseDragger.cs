namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseFieldMouseDragger
{

	protected BaseFieldMouseDragger() { }

	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	public void SetDragZone(VisualElement dragElement) { }

}

