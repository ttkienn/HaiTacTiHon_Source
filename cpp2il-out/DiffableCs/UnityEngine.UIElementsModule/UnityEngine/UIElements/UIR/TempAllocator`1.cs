namespace UnityEngine.UIElements.UIR;

internal class TempAllocator : IDisposable
{
	private struct Page
	{
		public NativeArray<T> array; //Field offset: 0x0
		public int used; //Field offset: 0x0

	}

	private readonly int m_ExcessMinCapacity; //Field offset: 0x0
	private readonly int m_ExcessMaxCapacity; //Field offset: 0x0
	private Page<T> m_Pool; //Field offset: 0x0
	private List<Page<T>> m_Excess; //Field offset: 0x0
	private int m_NextExcessSize; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TempAllocator`1(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }

	public NativeSlice<T> Alloc(int count) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	private void ReleaseExcess() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

