namespace UnityEngine.TextCore.Text;

internal class TextInfo
{
	private static Vector2 s_InfinityVectorPositive; //Field offset: 0x0
	private static Vector2 s_InfinityVectorNegative; //Field offset: 0x8
	public int characterCount; //Field offset: 0x10
	public int spriteCount; //Field offset: 0x14
	public int spaceCount; //Field offset: 0x18
	public int wordCount; //Field offset: 0x1C
	public int linkCount; //Field offset: 0x20
	public int lineCount; //Field offset: 0x24
	public int pageCount; //Field offset: 0x28
	public int materialCount; //Field offset: 0x2C
	public TextElementInfo[] textElementInfo; //Field offset: 0x30
	public WordInfo[] wordInfo; //Field offset: 0x38
	public LinkInfo[] linkInfo; //Field offset: 0x40
	public LineInfo[] lineInfo; //Field offset: 0x48
	public PageInfo[] pageInfo; //Field offset: 0x50
	public MeshInfo[] meshInfo; //Field offset: 0x58
	public bool isDirty; //Field offset: 0x60
	public bool hasMultipleColors; //Field offset: 0x61

	private static TextInfo() { }

	public TextInfo() { }

	internal void Clear() { }

	internal void ClearLineInfo() { }

	internal void ClearMeshInfo(bool updateMesh) { }

	internal void ClearPageInfo() { }

	internal static void Resize(ref T[] array, int size) { }

	internal static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

}

