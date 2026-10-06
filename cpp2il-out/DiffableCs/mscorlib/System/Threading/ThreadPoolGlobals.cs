namespace System.Threading;

internal static class ThreadPoolGlobals
{
	public static int processorCount; //Field offset: 0x0
	public static bool vmTpInitialized; //Field offset: 0x4
	public static bool enableWorkerTracking; //Field offset: 0x5
	public static readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x8

	private static ThreadPoolGlobals() { }

}

