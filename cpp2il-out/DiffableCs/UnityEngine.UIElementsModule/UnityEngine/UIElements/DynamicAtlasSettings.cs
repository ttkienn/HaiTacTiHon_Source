namespace UnityEngine.UIElements;

public class DynamicAtlasSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_MinAtlasSize; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	private int m_MaxSubTextureSize; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x1C
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x20

	public DynamicAtlasFilters activeFilters
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public DynamicAtlasCustomFilter customFilter
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public static DynamicAtlasFilters defaultFilters
	{
		 get { } //Length: 7
	}

	public static DynamicAtlasSettings defaults
	{
		 get { } //Length: 128
	}

	public int maxAtlasSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int maxSubTextureSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int minAtlasSize
	{
		 get { } //Length: 191
		 set { } //Length: 4
	}

	public DynamicAtlasSettings() { }

	public DynamicAtlasFilters get_activeFilters() { }

	public DynamicAtlasCustomFilter get_customFilter() { }

	public static DynamicAtlasFilters get_defaultFilters() { }

	public static DynamicAtlasSettings get_defaults() { }

	public int get_maxAtlasSize() { }

	public int get_maxSubTextureSize() { }

	public int get_minAtlasSize() { }

	public void set_activeFilters(DynamicAtlasFilters value) { }

	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	public void set_maxAtlasSize(int value) { }

	public void set_maxSubTextureSize(int value) { }

	public void set_minAtlasSize(int value) { }

}

