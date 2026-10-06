namespace Unity.Services.Core.Internal;

internal interface IComponentRegistry
{

	public TComponent GetServiceComponent() { }

	public void RegisterServiceComponent(TComponent component) { }

	public void ResetProvidedComponents(IDictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

	public bool TryGetServiceComponent(out TComponent component) { }

}

