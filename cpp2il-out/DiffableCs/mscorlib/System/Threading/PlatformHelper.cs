namespace System.Threading;

internal static class PlatformHelper
{
	private static int s_processorCount; //Field offset: 0x0
	private static int s_lastProcessorCountRefreshTicks; //Field offset: 0x4
	internal static readonly bool IsSingleProcessor; //Field offset: 0x8

	internal static int ProcessorCount
	{
		internal get { } //Length: 262
	}

	private static PlatformHelper() { }

	internal static int get_ProcessorCount() { }

}

