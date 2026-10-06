namespace Unity.Services.Core.Internal;

internal interface IServiceRegistry
{

	public T GetService() { }

	public void RegisterService(T service) { }

}

