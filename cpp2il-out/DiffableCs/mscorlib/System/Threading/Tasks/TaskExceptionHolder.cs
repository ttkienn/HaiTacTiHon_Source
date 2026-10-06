namespace System.Threading.Tasks;

internal class TaskExceptionHolder
{
	private static readonly bool s_failFastOnUnobservedException; //Field offset: 0x0
	private readonly Task m_task; //Field offset: 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; //Field offset: 0x18
	private ExceptionDispatchInfo m_cancellationException; //Field offset: 0x20
	private bool m_isHandled; //Field offset: 0x28

	internal bool ContainsFaultList
	{
		internal get { } //Length: 27
	}

	private static TaskExceptionHolder() { }

	internal TaskExceptionHolder(Task task) { }

	internal void Add(object exceptionObject, bool representsCancellation) { }

	private void AddFaultException(object exceptionObject) { }

	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	protected virtual void Finalize() { }

	internal bool get_ContainsFaultList() { }

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	internal void MarkAsHandled(bool calledFromFinalizer) { }

	private void MarkAsUnhandled() { }

	private void SetCancellationException(object exceptionObject) { }

	private static bool ShouldFailFastOnUnobservedException() { }

}

