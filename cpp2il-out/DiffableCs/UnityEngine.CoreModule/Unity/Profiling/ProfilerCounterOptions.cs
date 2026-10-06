namespace Unity.Profiling;

[Flags]
public enum ProfilerCounterOptions
{
	None = 0,
	FlushOnEndOfFrame = 2,
	ResetToZeroOnFlush = 4,
}

