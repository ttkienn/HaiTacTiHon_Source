namespace UnityEngine.UIElements;

internal struct TextureId
{
	public static readonly TextureId invalid; //Field offset: 0x0
	private readonly int m_Index; //Field offset: 0x0

	public int index
	{
		 get { } //Length: 5
	}

	private static TextureId() { }

	public TextureId(int index) { }

	public float ConvertToGpu() { }

	public virtual bool Equals(object obj) { }

	public int get_index() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TextureId left, TextureId right) { }

	public static bool op_Inequality(TextureId left, TextureId right) { }

}

