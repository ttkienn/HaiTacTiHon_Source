namespace Uniject;

[Preserve]
internal class UnityThreadUtils : IThreadUtils
{
	private static int s_UnityThreadId; //Field offset: 0x0
	private static TaskScheduler UnityThreadScheduler; //Field offset: 0x8

	public override bool IsRunningOnMainThread
	{
		 get { } //Length: 83
	}

	public UnityThreadUtils() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void CaptureUnityThreadInfo() { }

	public override bool get_IsRunningOnMainThread() { }

	public override Task PostAsync(Action action) { }

	public override Task PostAsync(Action<Object> action, object state) { }

	public override Task<T> PostAsync(Func<T> action) { }

	public override Task<T> PostAsync(Func<Object, T> action, object state) { }

}

