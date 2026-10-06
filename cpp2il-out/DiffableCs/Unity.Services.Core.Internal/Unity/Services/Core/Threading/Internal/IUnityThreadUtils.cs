namespace Unity.Services.Core.Threading.Internal;

public interface IUnityThreadUtils : IServiceComponent
{

	public bool IsRunningOnUnityThread
	{
		 get { } //Length: 0
	}

	public bool get_IsRunningOnUnityThread() { }

	public Task PostAsync(Action action) { }

	public Task PostAsync(Action<Object> action, object state) { }

	public Task<T> PostAsync(Func<T> action) { }

	public Task<T> PostAsync(Func<Object, T> action, object state) { }

	public void Send(Action action) { }

	public void Send(Action<Object> action, object state) { }

	public T Send(Func<T> action) { }

	public T Send(Func<Object, T> action, object state) { }

}

