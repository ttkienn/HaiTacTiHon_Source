namespace UnityEngine.UIElements;

internal class UIRAtlasAllocator : IDisposable
{
	private class AreaNode
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal AreaNode <.cctor>b__9_0() { }

		}

		private static ObjectPool<AreaNode> s_Pool; //Field offset: 0x0
		public RectInt rect; //Field offset: 0x10
		public AreaNode previous; //Field offset: 0x20
		public AreaNode next; //Field offset: 0x28

		private static AreaNode() { }

		public AreaNode() { }

		public static AreaNode Acquire(RectInt rect) { }

		public void AddAfter(AreaNode previous) { }

		public void Release() { }

		public void RemoveFromChain() { }

	}

	private class Row
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal Row <.cctor>b__21_0() { }

		}

		private static ObjectPool<Row> s_Pool; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <offsetX>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <offsetY>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <width>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <height>k__BackingField; //Field offset: 0x1C
		public int Cursor; //Field offset: 0x20

		private int height
		{
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private int offsetX
		{
			[CompilerGenerated]
			 get { } //Length: 191
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private int offsetY
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private int width
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		private static Row() { }

		public Row() { }

		public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

		[CompilerGenerated]
		public int get_offsetX() { }

		[CompilerGenerated]
		public int get_offsetY() { }

		[CompilerGenerated]
		public int get_width() { }

		public void Release() { }

		[CompilerGenerated]
		private void set_height(int value) { }

		[CompilerGenerated]
		private void set_offsetX(int value) { }

		[CompilerGenerated]
		private void set_offsetY(int value) { }

		[CompilerGenerated]
		private void set_width(int value) { }

	}

	private static ProfilerMarker s_MarkerTryAllocate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxAtlasSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxImageWidth>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <maxImageHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <virtualWidth>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <virtualHeight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <physicalWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <physicalHeight>k__BackingField; //Field offset: 0x28
	private AreaNode m_FirstUnpartitionedArea; //Field offset: 0x30
	private Row[] m_OpenRows; //Field offset: 0x38
	private int m_1SidePadding; //Field offset: 0x40
	private int m_2SidePadding; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int maxAtlasSize
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	public int maxImageHeight
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int maxImageWidth
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public private int physicalHeight
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int physicalWidth
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int virtualHeight
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int virtualWidth
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static UIRAtlasAllocator() { }

	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1) { }

	private void BuildAreas() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	public int get_maxAtlasSize() { }

	[CompilerGenerated]
	public int get_maxImageHeight() { }

	[CompilerGenerated]
	public int get_maxImageWidth() { }

	[CompilerGenerated]
	public int get_physicalHeight() { }

	[CompilerGenerated]
	public int get_physicalWidth() { }

	[CompilerGenerated]
	public int get_virtualHeight() { }

	[CompilerGenerated]
	public int get_virtualWidth() { }

	private static int GetLog2OfNextPower(int n) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	private void set_physicalHeight(int value) { }

	[CompilerGenerated]
	private void set_physicalWidth(int value) { }

	[CompilerGenerated]
	private void set_virtualHeight(int value) { }

	[CompilerGenerated]
	private void set_virtualWidth(int value) { }

	public bool TryAllocate(int width, int height, out RectInt location) { }

	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

}

