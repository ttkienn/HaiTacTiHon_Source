namespace Unity.Services.Core.Internal;

internal class ServiceRegistry : IServiceRegistry
{
	[CompilerGenerated]
	private readonly Dictionary<Int32, Object> <ServiceTypeHashToInstance>k__BackingField; //Field offset: 0x10

	[NotNull]
	internal Dictionary<Int32, Object> ServiceTypeHashToInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public ServiceRegistry() { }

	public ServiceRegistry(Dictionary<Int32, Object> serviceTypeHashToInstance) { }

	[CompilerGenerated]
	internal Dictionary<Int32, Object> get_ServiceTypeHashToInstance() { }

	public override T GetService() { }

	public override void RegisterService(T service) { }

}

