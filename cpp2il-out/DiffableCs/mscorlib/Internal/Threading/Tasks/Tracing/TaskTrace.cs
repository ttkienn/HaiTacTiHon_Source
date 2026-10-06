namespace Internal.Threading.Tasks.Tracing;

internal static class TaskTrace
{
	private static TaskTraceCallbacks s_callbacks; //Field offset: 0x0

	public static bool Enabled
	{
		 get { } //Length: 91
	}

	public static bool get_Enabled() { }

	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }

	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

}

