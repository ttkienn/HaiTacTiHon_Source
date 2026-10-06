namespace UnityEngine.UIElements;

[Extension]
internal static class KeyboardEventExtensions
{

	[Extension]
	internal static bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	[Extension]
	internal static bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}

