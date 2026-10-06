namespace Unity.Services.Core.Threading.Internal;

internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent
{

	private override bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.IsRunningOnUnityThread
	{
		private get { } //Length: 7
	}

	public UnityThreadUtilsInternal() { }

	public static Task<T> PostAsync(Func<Object, T> action, object state) { }

	public static Task PostAsync(Action action) { }

	public static Task PostAsync(Action<Object> action, object state) { }

	public static Task<T> PostAsync(Func<T> action) { }

	public static void Send(Action action) { }

	public static void Send(Action<Object> action, object state) { }

	public static T Send(Func<T> action) { }

	public static T Send(Func<Object, T> action, object state) { }

	private override bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.get_IsRunningOnUnityThread() { }

	private override Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Action action) { }

	private override Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Action<Object> action, object state) { }

	private override Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Func<T> action) { }

	private override Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Func<Object, T> action, object state) { }

	private override T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Func<Object, T> action, object state) { }

	private override void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Action action) { }

	private override void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Action<Object> action, object state) { }

	private override T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Func<T> action) { }

}

