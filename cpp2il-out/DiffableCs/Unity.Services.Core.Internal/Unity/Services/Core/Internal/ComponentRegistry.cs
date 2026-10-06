namespace Unity.Services.Core.Internal;

internal class ComponentRegistry : IComponentRegistry
{
	[CompilerGenerated]
	private readonly Dictionary<Int32, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; //Field offset: 0x10

	[NotNull]
	internal Dictionary<Int32, IServiceComponent> ComponentTypeHashToInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public ComponentRegistry() { }

	public ComponentRegistry(Dictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

	[CompilerGenerated]
	internal Dictionary<Int32, IServiceComponent> get_ComponentTypeHashToInstance() { }

	public override TComponent GetServiceComponent() { }

	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	public override void RegisterServiceComponent(TComponent component) { }

	public override void ResetProvidedComponents(IDictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

	public override bool TryGetServiceComponent(out TComponent component) { }

}

