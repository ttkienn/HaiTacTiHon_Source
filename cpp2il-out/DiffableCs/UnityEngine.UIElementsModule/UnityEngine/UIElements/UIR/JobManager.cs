namespace UnityEngine.UIElements.UIR;

internal class JobManager : IDisposable
{
	private NativePagedList<NudgeJobData> m_NudgeJobs; //Field offset: 0x10
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; //Field offset: 0x18
	private NativePagedList<CopyClosingMeshJobData> m_CopyClosingMeshJobs; //Field offset: 0x20
	private JobMerger m_JobMerger; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x30

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public JobManager() { }

	public void Add(ref NudgeJobData job) { }

	public void Add(ref ConvertMeshJobData job) { }

	public void Add(ref CopyClosingMeshJobData job) { }

	public void CompleteClosingMeshJobs() { }

	public void CompleteConvertMeshJobs() { }

	public void CompleteNudgeJobs() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

