namespace Internal.Runtime.Augments;

internal abstract class TaskTraceCallbacks
{

	public abstract bool Enabled
	{
		 get { } //Length: 0
	}

	public abstract bool get_Enabled() { }

	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }

	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

}

