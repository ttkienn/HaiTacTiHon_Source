namespace UnityEngine.UI;

public class CanvasUpdateRegistry
{
	private static CanvasUpdateRegistry s_Instance; //Field offset: 0x0
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; //Field offset: 0x0
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; //Field offset: 0x8
	private bool m_PerformingLayoutUpdate; //Field offset: 0x10
	private bool m_PerformingGraphicUpdate; //Field offset: 0x11
	private String[] m_CanvasUpdateProfilerStrings; //Field offset: 0x18
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; //Field offset: 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; //Field offset: 0x28

	public static CanvasUpdateRegistry instance
	{
		 get { } //Length: 219
	}

	private static CanvasUpdateRegistry() { }

	protected CanvasUpdateRegistry() { }

	private void CleanInvalidItems() { }

	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	public static CanvasUpdateRegistry get_instance() { }

	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	public static bool IsRebuildingGraphics() { }

	public static bool IsRebuildingLayout() { }

	private bool ObjectValidForUpdate(ICanvasElement element) { }

	private static int ParentCount(Transform child) { }

	private void PerformUpdate() { }

	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

}

