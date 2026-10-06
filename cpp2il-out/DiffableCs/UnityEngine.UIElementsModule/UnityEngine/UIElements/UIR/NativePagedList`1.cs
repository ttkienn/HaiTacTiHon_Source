namespace UnityEngine.UIElements.UIR;

internal class NativePagedList : IDisposable
{
	private readonly int k_PoolCapacity; //Field offset: 0x0
	private List<NativeArray`1<T>> m_Pages; //Field offset: 0x0
	private NativeArray<T> m_CurrentPage; //Field offset: 0x0
	private int m_CurrentPageCount; //Field offset: 0x0
	private List<NativeSlice`1<T>> m_Enumerator; //Field offset: 0x0
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

	public NativePagedList`1(int poolCapacity) { }

	public void Add(ref T data) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public List<NativeSlice`1<T>> GetPages() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

