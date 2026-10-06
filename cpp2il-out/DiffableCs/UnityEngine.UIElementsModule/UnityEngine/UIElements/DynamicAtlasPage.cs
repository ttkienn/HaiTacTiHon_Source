namespace UnityEngine.UIElements;

internal class DynamicAtlasPage : IDisposable
{
	private static int s_TextureCounter; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextureId <textureId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderTexture <atlas>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly RenderTextureFormat <format>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly FilterMode <filterMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Vector2Int <minSize>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Vector2Int <maxSize>k__BackingField; //Field offset: 0x30
	private readonly int m_1Padding; //Field offset: 0x38
	private readonly int m_2Padding; //Field offset: 0x3C
	private Allocator2D m_Allocator; //Field offset: 0x40
	private TextureBlitter m_Blitter; //Field offset: 0x48
	private Vector2Int m_CurrentSize; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x58

	public private RenderTexture atlas
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FilterMode filterMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public RenderTextureFormat format
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public private TextureId textureId
	{
		[CompilerGenerated]
		 get { } //Length: 191
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	public void Commit() { }

	private RenderTexture CreateAtlasTexture() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public RenderTexture get_atlas() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	public FilterMode get_filterMode() { }

	[CompilerGenerated]
	public RenderTextureFormat get_format() { }

	[CompilerGenerated]
	public TextureId get_textureId() { }

	public void Remove(Alloc2D alloc) { }

	[CompilerGenerated]
	private void set_atlas(RenderTexture value) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	private void set_textureId(TextureId value) { }

	public bool TryAdd(Texture2D image, out Alloc2D alloc, out RectInt rect) { }

	public void Update(Texture2D image, RectInt rect) { }

	private void UpdateAtlasTexture() { }

}

