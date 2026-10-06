namespace UnityEngine.UIElements;

internal abstract class BaseRuntimePanel : Panel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Vector2 <.cctor>b__47_0(Vector2 p) { }

	}

	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; //Field offset: 0x8
	private GameObject m_SelectableGameObject; //Field offset: 0x160
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0x168
	private float m_SortingPriority; //Field offset: 0x16C
	internal int resolvedSortingIndex; //Field offset: 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action destroyed; //Field offset: 0x178
	private Shader m_StandardWorldSpaceShader; //Field offset: 0x180
	private bool m_DrawToCameras; //Field offset: 0x188
	internal RenderTexture targetTexture; //Field offset: 0x190
	internal Matrix4x4 panelToWorld; //Field offset: 0x198
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <targetDisplay>k__BackingField; //Field offset: 0x1D8
	private Func<Vector2, Vector2> m_ScreenToPanelSpace; //Field offset: 0x1E0

	public event Action destroyed
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	internal bool drawToCameras
	{
		internal get { } //Length: 10
		internal set { } //Length: 176
	}

	internal int screenRenderingHeight
	{
		internal get { } //Length: 233
	}

	internal int screenRenderingWidth
	{
		internal get { } //Length: 233
	}

	public Func<Vector2, Vector2> screenToPanelSpace
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	public override GameObject selectableGameObject
	{
		 get { } //Length: 8
		 set { } //Length: 160
	}

	public float sortingPriority
	{
		 get { } //Length: 9
		 set { } //Length: 140
	}

	internal virtual Shader standardWorldSpaceShader
	{
		internal get { } //Length: 10
	}

	internal int targetDisplay
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	private static BaseRuntimePanel() { }

	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[CompilerGenerated]
	public void add_destroyed(Action value) { }

	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	protected virtual void Dispose(bool disposing) { }

	internal bool get_drawToCameras() { }

	internal int get_screenRenderingHeight() { }

	internal int get_screenRenderingWidth() { }

	public Func<Vector2, Vector2> get_screenToPanelSpace() { }

	public override GameObject get_selectableGameObject() { }

	public float get_sortingPriority() { }

	internal virtual Shader get_standardWorldSpaceShader() { }

	[CompilerGenerated]
	internal int get_targetDisplay() { }

	internal static int getScreenRenderingHeight(int display) { }

	internal static int getScreenRenderingWidth(int display) { }

	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	[CompilerGenerated]
	public void remove_destroyed(Action value) { }

	public virtual void Repaint(Event e) { }

	internal Vector2 ScreenToPanel(Vector2 screen) { }

	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false) { }

	internal void set_drawToCameras(bool value) { }

	public void set_screenToPanelSpace(Func<Vector2, Vector2> value) { }

	public override void set_selectableGameObject(GameObject value) { }

	public void set_sortingPriority(float value) { }

	[CompilerGenerated]
	internal void set_targetDisplay(int value) { }

}

