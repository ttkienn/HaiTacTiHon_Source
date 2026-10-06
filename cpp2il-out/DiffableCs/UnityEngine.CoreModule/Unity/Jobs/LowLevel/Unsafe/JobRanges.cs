namespace Unity.Jobs.LowLevel.Unsafe;

public struct JobRanges
{
	internal int BatchSize; //Field offset: 0x0
	internal int NumJobs; //Field offset: 0x4
	public int TotalIterationCount; //Field offset: 0x8
	internal IntPtr StartEndIndex; //Field offset: 0x10

}

