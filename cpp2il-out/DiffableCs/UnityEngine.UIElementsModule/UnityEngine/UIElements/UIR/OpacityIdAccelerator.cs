namespace UnityEngine.UIElements.UIR;

internal class OpacityIdAccelerator : IDisposable
{
	private struct OpacityIdUpdateJob : IJobParallelFor
	{
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> oldVerts; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> newVerts; //Field offset: 0x10
		public Color32 opacityData; //Field offset: 0x20

		public override void Execute(int i) { }

	}

	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	private int m_NextJobIndex; //Field offset: 0x20
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

	public OpacityIdAccelerator() { }

	public void CompleteJobs() { }

	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

