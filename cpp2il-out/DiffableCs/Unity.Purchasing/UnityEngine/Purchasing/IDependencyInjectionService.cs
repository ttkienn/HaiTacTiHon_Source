namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IDependencyInjectionService
{

	public void AddInstance(object instance) { }

	public void AddService() { }

	public T GetInstance() { }

}

