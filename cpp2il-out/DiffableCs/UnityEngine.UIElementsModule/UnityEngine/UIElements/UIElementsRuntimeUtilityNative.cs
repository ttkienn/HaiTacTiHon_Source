namespace UnityEngine.UIElements;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/UIElementsRuntimeUtilityNative.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"}])]
internal static class UIElementsRuntimeUtilityNative
{
	internal static Action RepaintOverlayPanelsCallback; //Field offset: 0x0
	internal static Action UpdateRuntimePanelsCallback; //Field offset: 0x8
	internal static Action RepaintOffscreenPanelsCallback; //Field offset: 0x10

	public static void RegisterPlayerloopCallback() { }

	[RequiredByNativeCode]
	public static void RepaintOffscreenPanels() { }

	[RequiredByNativeCode]
	public static void RepaintOverlayPanels() { }

	public static void UnregisterPlayerloopCallback() { }

	[RequiredByNativeCode]
	public static void UpdateRuntimePanels() { }

	public static void VisualElementCreation() { }

}

