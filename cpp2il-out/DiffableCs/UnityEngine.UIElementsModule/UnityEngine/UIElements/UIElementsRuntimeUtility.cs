namespace UnityEngine.UIElements;

internal static class UIElementsRuntimeUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Panel> <>9__48_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__9_0() { }

		internal void <.cctor>b__9_1(int displayIndex, int sortOrder) { }

		internal int <SortPanels>b__48_0(Panel a, Panel b) { }

	}

	internal sealed class CreateRuntimePanelDelegate : MulticastDelegate
	{

		public CreateRuntimePanelDelegate(object object, IntPtr method) { }

		public override BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<BaseRuntimePanel> onCreatePanel; //Field offset: 0x0
	private static bool s_RegisteredPlayerloopCallback; //Field offset: 0x8
	private static List<Panel> s_SortedRuntimePanels; //Field offset: 0x10
	private static bool s_PanelOrderingDirty; //Field offset: 0x18
	internal static int s_ResolvedSortingIndexMax; //Field offset: 0x1C
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x20
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x28
	private static int currentOverlayIndex; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static object <activeEventSystem>k__BackingField; //Field offset: 0x38
	private static DefaultEventSystem s_DefaultEventSystem; //Field offset: 0x40
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; //Field offset: 0x48

	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[CompilerGenerated]
		 add { } //Length: 257
		[CompilerGenerated]
		 remove { } //Length: 257
	}

	internal static object activeEventSystem
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 110
	}

	internal static DefaultEventSystem defaultEventSystem
	{
		internal get { } //Length: 199
	}

	internal static bool useDefaultEventSystem
	{
		internal get { } //Length: 173
	}

	private static UIElementsRuntimeUtility() { }

	[CompilerGenerated]
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	internal static void BeginRenderOverlays(int displayIndex) { }

	public static EventBase CreateEvent(Event systemEvent) { }

	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	internal static void EndRenderOverlays(int displayIndex) { }

	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	[CompilerGenerated]
	internal static object get_activeEventSystem() { }

	internal static DefaultEventSystem get_defaultEventSystem() { }

	internal static bool get_useDefaultEventSystem() { }

	internal static List<Panel> GetSortedPlayerPanels() { }

	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	public static void RegisterEventSystem(object eventSystem) { }

	public static void RegisterPlayerloopCallback() { }

	[CompilerGenerated]
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	private static void RemoveCachedPanelInternal(int instanceID) { }

	internal static void RemoveUnusedPanels() { }

	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	public static void RepaintOffscreenPanels() { }

	public static void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[CompilerGenerated]
	private static void set_activeEventSystem(object value) { }

	internal static void SetPanelOrderingDirty() { }

	private static void SortPanels() { }

	public static void UnregisterEventSystem(object eventSystem) { }

	public static void UnregisterPlayerloopCallback() { }

	public static void UpdateRuntimePanels() { }

}

