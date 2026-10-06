namespace UnityEngine.UIElements.UIR;

internal class Allocator2D
{
	internal struct Alloc2D
	{
		public RectInt rect; //Field offset: 0x0
		public Row row; //Field offset: 0x10
		public Alloc alloc; //Field offset: 0x18

		public Alloc2D(Row row, Alloc alloc, int width, int height) { }

	}

	internal class Area
	{
		public RectInt rect; //Field offset: 0x10
		public BestFitAllocator allocator; //Field offset: 0x20

		public Area(RectInt rect) { }

	}

	internal class Row : LinkedPoolItem<Row>
	{
		public static readonly LinkedPool<Row> pool; //Field offset: 0x0
		public RectInt rect; //Field offset: 0x18
		public Area area; //Field offset: 0x28
		public BestFitAllocator allocator; //Field offset: 0x30
		public Alloc alloc; //Field offset: 0x38
		public Row next; //Field offset: 0x50

		private static Row() { }

		public Row() { }

		private static Row Create() { }

		private static void Reset(Row row) { }

	}

	private readonly Vector2Int m_MinSize; //Field offset: 0x10
	private readonly Vector2Int m_MaxSize; //Field offset: 0x18
	private readonly Vector2Int m_MaxAllocSize; //Field offset: 0x20
	private readonly int m_RowHeightBias; //Field offset: 0x28
	private readonly Row[] m_Rows; //Field offset: 0x30
	private readonly List<Area> m_Areas; //Field offset: 0x38

	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) { }

	public void Free(Alloc2D alloc2D) { }

	public bool TryAllocate(int width, int height, out Alloc2D alloc2D) { }

}

