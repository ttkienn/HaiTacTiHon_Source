namespace UnityEngine.UIElements;

internal class UIElementsUtility : IUIElementsUtility
{
	private static Stack<IMGUIContainer> s_ContainerStack; //Field offset: 0x0
	private static Dictionary<Int32, Panel> s_UIElementsCache; //Field offset: 0x8
	private static Event s_EventInstance; //Field offset: 0x10
	internal static Color editorPlayModeTintColor; //Field offset: 0x18
	internal static float singleLineHeight; //Field offset: 0x28
	private static UIElementsUtility s_Instance; //Field offset: 0x30
	internal static List<Panel> s_PanelsIterationList; //Field offset: 0x38
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x40
	internal static readonly string s_EventProfilerMarkerName; //Field offset: 0x48
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x50
	private static readonly ProfilerMarker s_EventProfilerMarker; //Field offset: 0x58
	internal static Char[] s_Modifiers; //Field offset: 0x60

	private static UIElementsUtility() { }

	private UIElementsUtility() { }

	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	internal static EventBase CreateEvent(Event systemEvent) { }

	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	internal static Enumerator<Int32, Panel> GetPanelsIterator() { }

	internal static string ParseMenuName(string menuName) { }

	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	public static void RemoveCachedPanel(int instanceID) { }

	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

}

