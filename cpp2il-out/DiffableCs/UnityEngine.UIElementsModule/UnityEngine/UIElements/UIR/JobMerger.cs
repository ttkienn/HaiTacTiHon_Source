namespace UnityEngine.UIElements.UIR;

internal class JobMerger : IDisposable
{
	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	private int m_JobCount; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public JobMerger(int capacity) { }

	public void Add(JobHandle job) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public JobHandle MergeAndReset() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

