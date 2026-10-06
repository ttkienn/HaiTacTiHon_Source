namespace UnityEngine.UIElements;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIPainter2D.bindings.h")]
internal static class UIPainter2D
{

	public static IntPtr Create(bool computeBBox = false) { }

	public static void Destroy(IntPtr handle) { }

	public static void Reset(IntPtr handle) { }

}

