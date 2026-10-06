namespace UnityEngine.UIElements.UIR;

internal class RenderChain : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RenderChainCommand> <>9__34_0; //Field offset: 0x8
		public static Action<RenderChainCommand> <>9__34_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal RenderChainCommand <.ctor>b__34_0() { }

		internal void <.ctor>b__34_1(RenderChainCommand cmd) { }

	}

	private struct DepthOrderedDirtyTracking
	{
		public List<VisualElement> heads; //Field offset: 0x0
		public List<VisualElement> tails; //Field offset: 0x8
		public Int32[] minDepths; //Field offset: 0x10
		public Int32[] maxDepths; //Field offset: 0x18
		public uint dirtyID; //Field offset: 0x20

		public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

		public void EnsureFits(int maxDepth) { }

		public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

		public void Reset() { }

	}

	private struct RenderChainStaticIndexAllocator
	{
		private static List<RenderChain> renderChains; //Field offset: 0x0

		private static RenderChainStaticIndexAllocator() { }

		public static RenderChain AccessIndex(int index) { }

		public static int AllocateIndex(RenderChain renderChain) { }

		public static void FreeIndex(int index) { }

	}

	private struct RenderNodeData
	{
		public Material standardMaterial; //Field offset: 0x0
		public Material initialMaterial; //Field offset: 0x8
		public MaterialPropertyBlock matPropBlock; //Field offset: 0x10
		public RenderChainCommand firstCommand; //Field offset: 0x18
		public UIRenderDevice device; //Field offset: 0x20
		public Texture vectorAtlas; //Field offset: 0x28
		public Texture shaderInfoAtlas; //Field offset: 0x30
		public float dpiScale; //Field offset: 0x38
		public NativeSlice<Transform3x4> transformConstants; //Field offset: 0x40
		public NativeSlice<Vector4> clipRectConstants; //Field offset: 0x50

	}

	private static ProfilerMarker s_MarkerProcess; //Field offset: 0x0
	private static ProfilerMarker s_MarkerClipProcessing; //Field offset: 0x8
	private static ProfilerMarker s_MarkerOpacityProcessing; //Field offset: 0x10
	private static ProfilerMarker s_MarkerColorsProcessing; //Field offset: 0x18
	private static ProfilerMarker s_MarkerTransformProcessing; //Field offset: 0x20
	private static ProfilerMarker s_MarkerVisualsProcessing; //Field offset: 0x28
	private static ProfilerMarker s_MarkerTextRegen; //Field offset: 0x30
	internal static Action OnPreRender; //Field offset: 0x38
	private RenderChainCommand m_FirstCommand; //Field offset: 0x10
	private DepthOrderedDirtyTracking m_DirtyTracker; //Field offset: 0x18
	private LinkedPool<RenderChainCommand> m_CommandPool; //Field offset: 0x40
	private BasicNodePool<TextureEntry> m_TexturePool; //Field offset: 0x48
	private List<RenderNodeData> m_RenderNodesData; //Field offset: 0x50
	private Shader m_DefaultShader; //Field offset: 0x58
	private Shader m_DefaultWorldSpaceShader; //Field offset: 0x60
	private Material m_DefaultMat; //Field offset: 0x68
	private Material m_DefaultWorldSpaceMat; //Field offset: 0x70
	private bool m_BlockDirtyRegistration; //Field offset: 0x78
	private int m_StaticIndex; //Field offset: 0x7C
	private int m_ActiveRenderNodes; //Field offset: 0x80
	private int m_CustomMaterialCommands; //Field offset: 0x84
	private ChainBuilderStats m_Stats; //Field offset: 0x88
	private uint m_StatsElementsAdded; //Field offset: 0xE8
	private uint m_StatsElementsRemoved; //Field offset: 0xEC
	private TextureRegistry m_TextureRegistry; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseVisualElementPanel <panel>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UIRenderDevice <device>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AtlasBase <atlas>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VectorImageManager <vectorImageManager>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TempAllocator<Vertex> <vertsPool>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TempAllocator<UInt16> <indicesPool>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private JobManager <jobManager>k__BackingField; //Field offset: 0x138
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; //Field offset: 0x140
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UIRStylePainter <painter>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawStats>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawInCameras>k__BackingField; //Field offset: 0x219

	internal AtlasBase atlas
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal Shader defaultShader
	{
		internal set { } //Length: 190
	}

	internal Shader defaultWorldSpaceShader
	{
		internal set { } //Length: 190
	}

	internal UIRenderDevice device
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal bool drawInCameras
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal bool drawStats
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal TempAllocator<UInt16> indicesPool
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal JobManager jobManager
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private OpacityIdAccelerator opacityIdAccelerator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal UIRStylePainter painter
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal BaseVisualElementPanel panel
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VectorImageManager vectorImageManager
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal TempAllocator<Vertex> vertsPool
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private static RenderChain() { }

	public RenderChain(BaseVisualElementPanel panel) { }

	private static RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	internal RenderChainCommand AllocCommand() { }

	internal void ChildWillBeRemoved(VisualElement ve) { }

	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	private void Destructor() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	private void DrawStats() { }

	internal void EnsureFitsDepth(int depth) { }

	internal void FreeCommand(RenderChainCommand cmd) { }

	[CompilerGenerated]
	internal AtlasBase get_atlas() { }

	[CompilerGenerated]
	internal UIRenderDevice get_device() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	internal bool get_drawInCameras() { }

	[CompilerGenerated]
	internal bool get_drawStats() { }

	[CompilerGenerated]
	internal TempAllocator<UInt16> get_indicesPool() { }

	[CompilerGenerated]
	internal JobManager get_jobManager() { }

	[CompilerGenerated]
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[CompilerGenerated]
	internal UIRStylePainter get_painter() { }

	[CompilerGenerated]
	internal BaseVisualElementPanel get_panel() { }

	[CompilerGenerated]
	internal VectorImageManager get_vectorImageManager() { }

	[CompilerGenerated]
	internal TempAllocator<Vertex> get_vertsPool() { }

	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }

	internal Material GetStandardMaterial() { }

	internal Material GetStandardWorldSpaceMaterial() { }

	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	private static void OnRegisterIntermediateRenderers(Camera camera) { }

	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	private static void OnRenderNodeExecute(IntPtr obj) { }

	public void ProcessChanges() { }

	public void Render() { }

	internal void RepaintTexturedElements() { }

	public void ResetTextures(VisualElement ve) { }

	[CompilerGenerated]
	private void set_atlas(AtlasBase value) { }

	internal void set_defaultShader(Shader value) { }

	internal void set_defaultWorldSpaceShader(Shader value) { }

	[CompilerGenerated]
	private void set_device(UIRenderDevice value) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	private void set_drawInCameras(bool value) { }

	[CompilerGenerated]
	internal void set_drawStats(bool value) { }

	[CompilerGenerated]
	private void set_indicesPool(TempAllocator<UInt16> value) { }

	[CompilerGenerated]
	private void set_jobManager(JobManager value) { }

	[CompilerGenerated]
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	[CompilerGenerated]
	private void set_painter(UIRStylePainter value) { }

	[CompilerGenerated]
	private void set_panel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	private void set_vectorImageManager(VectorImageManager value) { }

	[CompilerGenerated]
	private void set_vertsPool(TempAllocator<Vertex> value) { }

	public void UIEOnChildAdded(VisualElement ve) { }

	public void UIEOnChildRemoving(VisualElement ve) { }

	public void UIEOnChildrenReordered(VisualElement ve) { }

	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	public void UIEOnColorChanged(VisualElement ve) { }

	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false) { }

	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

}

