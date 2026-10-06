namespace UnityEngine.UIElements;

[Extension]
public static class UQueryExtensions
{
	private static UQueryState<VisualElement> SingleElementEmptyQuery; //Field offset: 0x0
	private static UQueryState<VisualElement> SingleElementNameQuery; //Field offset: 0x10
	private static UQueryState<VisualElement> SingleElementClassQuery; //Field offset: 0x20
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; //Field offset: 0x30
	private static UQueryState<VisualElement> SingleElementTypeQuery; //Field offset: 0x40
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; //Field offset: 0x50
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; //Field offset: 0x60
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; //Field offset: 0x70

	private static UQueryExtensions() { }

	[Extension]
	public static VisualElement Q(VisualElement e, string name = null, string className = null) { }

	[Extension]
	public static T Q(VisualElement e, string name = null, string className = null) { }

}

