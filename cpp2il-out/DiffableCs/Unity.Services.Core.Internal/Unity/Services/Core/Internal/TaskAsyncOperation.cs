namespace Unity.Services.Core.Internal;

internal class TaskAsyncOperation : AsyncOperationBase, INotifyCompletion
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Task, Object> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__10_0(Task t, object state) { }

	}

	internal static TaskScheduler Scheduler; //Field offset: 0x0
	private Task m_Task; //Field offset: 0x18

	public virtual Exception Exception
	{
		 get { } //Length: 19
	}

	public virtual bool IsCompleted
	{
		 get { } //Length: 29
	}

	public virtual AsyncOperationStatus Status
	{
		 get { } //Length: 118
	}

	public TaskAsyncOperation(Task task) { }

	public virtual Exception get_Exception() { }

	public virtual bool get_IsCompleted() { }

	public virtual AsyncOperationStatus get_Status() { }

	public virtual AsyncOperationBase GetAwaiter() { }

	public virtual void GetResult() { }

	public static TaskAsyncOperation Run(Action action) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	internal static void SetScheduler() { }

}

