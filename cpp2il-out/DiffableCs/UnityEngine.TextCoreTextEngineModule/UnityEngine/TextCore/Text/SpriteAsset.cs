namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2022.3/Documentation/Manual/UIE-sprite.html")]
public class SpriteAsset : TextAsset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SpriteGlyph, UInt32> <>9__37_0; //Field offset: 0x8
		public static Func<SpriteCharacter, UInt32> <>9__38_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal uint <SortCharacterTable>b__38_0(SpriteCharacter c) { }

		internal uint <SortGlyphTable>b__37_0(SpriteGlyph item) { }

	}

	private static HashSet<Int32> k_searchedSpriteAssets; //Field offset: 0x0
	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x38
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; //Field offset: 0xA8
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB0
	internal Dictionary<UInt32, SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xB8
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; //Field offset: 0xC0
	internal Dictionary<UInt32, SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xC8
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xD8

	public internal FaceInfo faceInfo
	{
		 get { } //Length: 57
		internal set { } //Length: 64
	}

	public internal Dictionary<UInt32, SpriteCharacter> spriteCharacterLookupTable
	{
		 get { } //Length: 52
		internal set { } //Length: 19
	}

	public internal List<SpriteCharacter> spriteCharacterTable
	{
		 get { } //Length: 49
		internal set { } //Length: 19
	}

	public internal List<SpriteGlyph> spriteGlyphTable
	{
		 get { } //Length: 10
		internal set { } //Length: 19
	}

	public internal Texture spriteSheet
	{
		 get { } //Length: 10
		internal set { } //Length: 19
	}

	public SpriteAsset() { }

	private void Awake() { }

	public FaceInfo get_faceInfo() { }

	public Dictionary<UInt32, SpriteCharacter> get_spriteCharacterLookupTable() { }

	public List<SpriteCharacter> get_spriteCharacterTable() { }

	public List<SpriteGlyph> get_spriteGlyphTable() { }

	public Texture get_spriteSheet() { }

	public int GetSpriteIndexFromHashcode(int hashCode) { }

	public int GetSpriteIndexFromName(string name) { }

	public int GetSpriteIndexFromUnicode(uint unicode) { }

	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null) { }

	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	internal void set_faceInfo(FaceInfo value) { }

	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, SpriteCharacter> value) { }

	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	internal void set_spriteSheet(Texture value) { }

	internal void SortCharacterTable() { }

	internal void SortGlyphAndCharacterTables() { }

	public void SortGlyphTable() { }

	public void UpdateLookupTables() { }

}

