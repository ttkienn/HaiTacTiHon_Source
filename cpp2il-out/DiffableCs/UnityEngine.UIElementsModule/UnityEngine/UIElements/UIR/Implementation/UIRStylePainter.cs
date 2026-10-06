namespace UnityEngine.UIElements.UIR.Implementation;

internal class UIRStylePainter : IStylePainter
{
	public struct ClosingInfo
	{
		public bool needsClosing; //Field offset: 0x0
		public bool popViewMatrix; //Field offset: 0x1
		public bool popScissorClip; //Field offset: 0x2
		public bool blitAndPopRenderTexture; //Field offset: 0x3
		public bool PopDefaultMaterial; //Field offset: 0x4
		public RenderChainCommand clipUnregisterDrawCommand; //Field offset: 0x8
		public NativeSlice<Vertex> clipperRegisterVertices; //Field offset: 0x10
		public NativeSlice<UInt16> clipperRegisterIndices; //Field offset: 0x20
		public int clipperRegisterIndexOffset; //Field offset: 0x30
		public int maskStencilRef; //Field offset: 0x34

	}

	public struct Entry
	{
		public NativeSlice<Vertex> vertices; //Field offset: 0x0
		public NativeSlice<UInt16> indices; //Field offset: 0x10
		public Material material; //Field offset: 0x20
		public float fontTexSDFScale; //Field offset: 0x28
		public TextureId texture; //Field offset: 0x2C
		public RenderChainCommand customCommand; //Field offset: 0x30
		public BMPAlloc clipRectID; //Field offset: 0x38
		public VertexFlags addFlags; //Field offset: 0x40
		public bool uvIsDisplacement; //Field offset: 0x44
		public bool isTextEntry; //Field offset: 0x45
		public bool isClipRegisterEntry; //Field offset: 0x46
		public int stencilRef; //Field offset: 0x48
		public int maskDepth; //Field offset: 0x4C

	}

	private struct RepeatRectUV
	{
		public Rect rect; //Field offset: 0x0
		public Rect uv; //Field offset: 0x10

	}

	private RenderChain m_Owner; //Field offset: 0x10
	private List<Entry> m_Entries; //Field offset: 0x18
	private AtlasBase m_Atlas; //Field offset: 0x20
	private VectorImageManager m_VectorImageManager; //Field offset: 0x28
	private Entry m_CurrentEntry; //Field offset: 0x30
	private ClosingInfo m_ClosingInfo; //Field offset: 0x80
	private int m_MaskDepth; //Field offset: 0xB8
	private int m_StencilRef; //Field offset: 0xBC
	private BMPAlloc m_ClipRectID; //Field offset: 0xC0
	private int m_SVGBackgroundEntryIndex; //Field offset: 0xC8
	private TempAllocator<Vertex> m_VertsPool; //Field offset: 0xD0
	private TempAllocator<UInt16> m_IndicesPool; //Field offset: 0xD8
	private List<MeshWriteData> m_MeshWriteDataPool; //Field offset: 0xE0
	private int m_NextMeshWriteDataPoolItem; //Field offset: 0xE8
	private List<RepeatRectUV>[] m_RepeatRectUVList; //Field offset: 0xF0
	private Allocator m_AllocRawVertsIndicesDelegate; //Field offset: 0xF8
	private Allocator m_AllocThroughDrawMeshDelegate; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshGenerationContext <meshGenerationContext>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <currentElement>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <totalVertices>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <totalIndices>k__BackingField; //Field offset: 0x11C
	private TextInfo m_TextInfo; //Field offset: 0x120

	public ClosingInfo closingInfo
	{
		 get { } //Length: 49
	}

	public private VisualElement currentElement
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public List<Entry> entries
	{
		 get { } //Length: 7
	}

	public MeshGenerationContext meshGenerationContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private int totalIndices
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int totalVertices
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override VisualElement visualElement
	{
		 get { } //Length: 10
	}

	public UIRStylePainter(RenderChain renderChain) { }

	private UInt16[] AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices) { }

	private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData) { }

	private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData) { }

	public void ApplyVisualElementClipping() { }

	public void Begin(VisualElement ve) { }

	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	public override void DrawBorder(BorderParams borderParams) { }

	public override void DrawImmediate(Action callback, bool cullingEnabled) { }

	public override MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshFlags flags) { }

	public override void DrawRectangle(RectangleParams rectParams) { }

	private void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	public void DrawSprite(RectangleParams rectParams) { }

	public override void DrawText(TextElement te) { }

	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	public void DrawVectorImage(RectangleParams rectParams) { }

	public void DrawVisualElementBackground() { }

	public void DrawVisualElementBorder() { }

	private void GenerateStencilClipEntryForRoundedRectBackground() { }

	private void GenerateStencilClipEntryForSVGBackground() { }

	public ClosingInfo get_closingInfo() { }

	[CompilerGenerated]
	public VisualElement get_currentElement() { }

	public List<Entry> get_entries() { }

	[CompilerGenerated]
	public MeshGenerationContext get_meshGenerationContext() { }

	[CompilerGenerated]
	public int get_totalIndices() { }

	[CompilerGenerated]
	public int get_totalVertices() { }

	public override VisualElement get_visualElement() { }

	private MeshWriteData GetPooledMeshWriteData() { }

	public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, int indexOffset) { }

	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	private void MakeVectorGraphics(RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount) { }

	internal void Reset() { }

	[CompilerGenerated]
	private void set_currentElement(VisualElement value) { }

	[CompilerGenerated]
	private void set_totalIndices(int value) { }

	[CompilerGenerated]
	private void set_totalVertices(int value) { }

	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV) { }

	internal void TryAtlasTexture(Texture texture, MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags) { }

	private void ValidateMeshWriteData() { }

}

