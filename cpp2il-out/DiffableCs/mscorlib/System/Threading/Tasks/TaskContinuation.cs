namespace System.Threading.Tasks;

internal abstract class TaskContinuation
{

	protected TaskContinuation() { }

	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

