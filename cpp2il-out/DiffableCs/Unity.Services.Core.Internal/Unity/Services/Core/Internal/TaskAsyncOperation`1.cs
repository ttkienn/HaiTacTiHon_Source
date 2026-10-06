namespace Unity.Services.Core.Internal;

internal class TaskAsyncOperation : AsyncOperationBase<T>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Action<Task`1<T>, Object> <>9__11_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__11_0(Task<T> t, object state) { }

	}

	private Task<T> m_Task; //Field offset: 0x0

	public virtual Exception Exception
	{
		 get { } //Length: 19
	}

	public virtual bool IsCompleted
	{
		 get { } //Length: 29
	}

	public virtual T Result
	{
		 get { } //Length: 169
	}

	public virtual AsyncOperationStatus Status
	{
		 get { } //Length: 118
	}

	public TaskAsyncOperation`1(Task<T> task) { }

	public virtual Exception get_Exception() { }

	public virtual bool get_IsCompleted() { }

	public virtual T get_Result() { }

	public virtual AsyncOperationStatus get_Status() { }

	public virtual AsyncOperationBase<T> GetAwaiter() { }

	public virtual T GetResult() { }

	public static TaskAsyncOperation<T> Run(Func<T> func) { }

}

