namespace Unity.Services.Core.Internal;

internal class LockedServiceRegistry : IServiceRegistry
{
	private const string k_ErrorMessage = "Service registration has been locked. Make sure to register service services before all packages have finished initializing."; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IServiceRegistry <Registry>k__BackingField; //Field offset: 0x10

	[NotNull]
	internal IServiceRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public LockedServiceRegistry(IServiceRegistry registryToLock) { }

	[CompilerGenerated]
	internal IServiceRegistry get_Registry() { }

	public override T GetService() { }

	public override void RegisterService(T service) { }

}

