namespace UnityEngine.UIElements;

internal class TextureRegistry
{
	private struct TextureInfo
	{
		public Texture texture; //Field offset: 0x0
		public bool dynamic; //Field offset: 0x8
		public int refCount; //Field offset: 0xC

	}

	internal const int maxTextures = 2048; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly TextureRegistry <instance>k__BackingField; //Field offset: 0x0
	private List<TextureInfo> m_Textures; //Field offset: 0x10
	private Dictionary<Texture, TextureId> m_TextureToId; //Field offset: 0x18
	private Stack<TextureId> m_FreeIds; //Field offset: 0x20

	public static TextureRegistry instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private static TextureRegistry() { }

	public TextureRegistry() { }

	public TextureId Acquire(Texture tex) { }

	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	public TextureId AllocAndAcquireDynamic() { }

	[CompilerGenerated]
	public static TextureRegistry get_instance() { }

	public Texture GetTexture(TextureId id) { }

	public void Release(TextureId id) { }

	public void UpdateDynamic(TextureId id, Texture texture) { }

}

