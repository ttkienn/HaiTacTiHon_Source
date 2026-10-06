namespace UnityEngine.UIElements;

[Extension]
public static class VisualElementExtensions
{

	[Extension]
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }

	[Extension]
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	[Extension]
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	public static void StretchToParentSize(VisualElement elem) { }

	[Extension]
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	[Extension]
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

}

