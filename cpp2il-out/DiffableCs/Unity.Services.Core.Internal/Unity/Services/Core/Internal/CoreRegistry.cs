namespace Unity.Services.Core.Internal;

public sealed class CoreRegistry
{
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; //Field offset: 0x38

	[NotNull]
	internal IComponentRegistry ComponentRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public internal static CoreRegistry Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		internal set { } //Length: 81
	}

	public string InstanceId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal InitializationOptions Options
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	[NotNull]
	internal IPackageRegistry PackageRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	[NotNull]
	internal IServiceRegistry ServiceRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal ServicesType Type
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId = null) { }

	internal CoreRegistry() { }

	[CompilerGenerated]
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	public string get_InstanceId() { }

	[CompilerGenerated]
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	internal IServiceRegistry get_ServiceRegistry() { }

	[CompilerGenerated]
	internal ServicesType get_Type() { }

	public T GetService() { }

	public TComponent GetServiceComponent() { }

	internal void LockComponentRegistration() { }

	internal void LockServiceRegistration() { }

	public CoreRegistration RegisterPackage(TPackage package) { }

	public void RegisterService(T service) { }

	public void RegisterServiceComponent(TComponent component) { }

	[CompilerGenerated]
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	internal void set_Options(InitializationOptions value) { }

	[CompilerGenerated]
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	private void set_ServiceRegistry(IServiceRegistry value) { }

	[CompilerGenerated]
	private void set_Type(ServicesType value) { }

	public bool TryGetServiceComponent(out TComponent component) { }

}

