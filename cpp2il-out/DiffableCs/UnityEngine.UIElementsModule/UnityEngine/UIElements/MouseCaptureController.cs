namespace UnityEngine.UIElements;

[Extension]
public static class MouseCaptureController
{

	[Extension]
	public static void CaptureMouse(IEventHandler handler) { }

	[Extension]
	public static bool HasMouseCapture(IEventHandler handler) { }

	[Extension]
	public static void ReleaseMouse(IEventHandler handler) { }

}

