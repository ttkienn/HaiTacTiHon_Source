namespace Uniject;

internal interface IThreadUtils
{

	public bool IsRunningOnMainThread
	{
		 get { } //Length: 0
	}

	public bool get_IsRunningOnMainThread() { }

	public Task PostAsync(Action action) { }

	public Task PostAsync(Action<Object> action, object state) { }

	public Task<T> PostAsync(Func<T> action) { }

	public Task<T> PostAsync(Func<Object, T> action, object state) { }

}

