namespace UnityEngine.UIElements;

internal class DynamicAtlas : AtlasBase
{
	private class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		public static readonly LinkedPool<TextureInfo> pool; //Field offset: 0x0
		public DynamicAtlasPage page; //Field offset: 0x18
		public int counter; //Field offset: 0x20
		public Alloc2D alloc; //Field offset: 0x28
		public RectInt rect; //Field offset: 0x58

		private static TextureInfo() { }

		public TextureInfo() { }

		private static TextureInfo Create() { }

		private static void Reset(TextureInfo info) { }

	}

	private Dictionary<Texture, TextureInfo> m_Database; //Field offset: 0x18
	private DynamicAtlasPage m_PointPage; //Field offset: 0x20
	private DynamicAtlasPage m_BilinearPage; //Field offset: 0x28
	private ColorSpace m_ColorSpace; //Field offset: 0x30
	private List<IPanel> m_Panels; //Field offset: 0x38
	private int m_MinAtlasSize; //Field offset: 0x40
	private int m_MaxAtlasSize; //Field offset: 0x44
	private int m_MaxSubTextureSize; //Field offset: 0x48
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x4C
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x50

	public DynamicAtlasFilters activeFilters
	{
		 set { } //Length: 29
	}

	public DynamicAtlasCustomFilter customFilter
	{
		 set { } //Length: 81
	}

	public static DynamicAtlasFilters defaultFilters
	{
		 get { } //Length: 6
	}

	internal bool isInitialized
	{
		internal get { } //Length: 23
	}

	public int maxAtlasSize
	{
		 set { } //Length: 29
	}

	public int maxSubTextureSize
	{
		 get { } //Length: 6
		 set { } //Length: 29
	}

	public int minAtlasSize
	{
		 set { } //Length: 29
	}

	public DynamicAtlas() { }

	private void DestroyPages() { }

	public static DynamicAtlasFilters get_defaultFilters() { }

	internal bool get_isInitialized() { }

	public int get_maxSubTextureSize() { }

	private void InitPages() { }

	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	public override bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	protected virtual void OnAssignedToPanel(IPanel panel) { }

	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	public virtual void Reset() { }

	public virtual void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	public void set_activeFilters(DynamicAtlasFilters value) { }

	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	public void set_maxAtlasSize(int value) { }

	public void set_maxSubTextureSize(int value) { }

	public void set_minAtlasSize(int value) { }

	public virtual bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

