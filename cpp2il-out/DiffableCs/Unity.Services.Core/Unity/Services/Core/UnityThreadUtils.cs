namespace Unity.Services.Core;

internal static class UnityThreadUtils
{
	private static int s_UnityThreadId; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; //Field offset: 0x8

	public static bool IsRunningOnUnityThread
	{
		 get { } //Length: 83
	}

	internal static TaskScheduler UnityThreadScheduler
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		private set { } //Length: 86
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void CaptureUnityThreadInfo() { }

	public static bool get_IsRunningOnUnityThread() { }

	[CompilerGenerated]
	internal static TaskScheduler get_UnityThreadScheduler() { }

	[CompilerGenerated]
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

}

