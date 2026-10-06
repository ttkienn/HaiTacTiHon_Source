namespace Unity.Services.Core.Internal;

internal class LockedComponentRegistry : IComponentRegistry
{
	private const string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing."; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; //Field offset: 0x10

	[NotNull]
	internal IComponentRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public LockedComponentRegistry(IComponentRegistry registryToLock) { }

	[CompilerGenerated]
	internal IComponentRegistry get_Registry() { }

	public override TComponent GetServiceComponent() { }

	public override void RegisterServiceComponent(TComponent component) { }

	public override void ResetProvidedComponents(IDictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

	public override bool TryGetServiceComponent(out TComponent component) { }

}

