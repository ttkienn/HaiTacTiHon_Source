namespace UnityEngine.UIElements.UIR;

internal struct BitmapAllocator32
{
	private struct Page
	{
		public ushort x; //Field offset: 0x0
		public ushort y; //Field offset: 0x2
		public int freeSlots; //Field offset: 0x4

	}

	private int m_PageHeight; //Field offset: 0x0
	private List<Page> m_Pages; //Field offset: 0x8
	private List<UInt32> m_AllocMap; //Field offset: 0x10
	private int m_EntryWidth; //Field offset: 0x18
	private int m_EntryHeight; //Field offset: 0x1C

	public int entryHeight
	{
		 get { } //Length: 6
	}

	public int entryWidth
	{
		 get { } //Length: 6
	}

	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	private static byte CountTrailingZeroes(uint val) { }

	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	public void Free(BMPAlloc alloc) { }

	public int get_entryHeight() { }

	public int get_entryWidth() { }

	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

}

