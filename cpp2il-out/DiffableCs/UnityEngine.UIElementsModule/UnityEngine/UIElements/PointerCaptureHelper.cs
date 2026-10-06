namespace UnityEngine.UIElements;

[Extension]
public static class PointerCaptureHelper
{

	[Extension]
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Extension]
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[Extension]
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[Extension]
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[Extension]
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Extension]
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

	[Extension]
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[Extension]
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[Extension]
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

}

