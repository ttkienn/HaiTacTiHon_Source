namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView`1))]
public class Task : Task
{
	private static TaskFactory<TResult> s_defaultFactory; //Field offset: 0x0
	internal TResult m_result; //Field offset: 0x0

	public static TaskFactory<TResult> Factory
	{
		 get { } //Length: 388
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public TResult Result
	{
		 get { } //Length: 131
	}

	internal TResult ResultOnSuccess
	{
		internal get { } //Length: 5
	}

	internal Task`1() { }

	internal Task`1(object state, TaskCreationOptions options) { }

	internal Task`1(TResult result) { }

	internal Task`1(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }

	public Task`1(Func<TResult> function) { }

	public Task`1(Func<TResult> function, CancellationToken cancellationToken) { }

	public Task`1(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	internal Task`1(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal Task`1(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	internal Task ContinueWith(Action<Task`1<TResult>, Object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Action<Task`1<TResult>, Object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler) { }

	internal Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	public Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }

	internal void DangerousSetResult(TResult result) { }

	public static TaskFactory<TResult> get_Factory() { }

	public TResult get_Result() { }

	internal TResult get_ResultOnSuccess() { }

	public TaskAwaiter<TResult> GetAwaiter() { }

	internal TResult GetResultCore(bool waitCompletionNotification) { }

	internal virtual void InnerInvoke() { }

	internal static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal bool TrySetResult(TResult result) { }

}

