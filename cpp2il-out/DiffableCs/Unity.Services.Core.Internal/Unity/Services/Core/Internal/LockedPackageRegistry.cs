namespace Unity.Services.Core.Internal;

internal class LockedPackageRegistry : IPackageRegistry
{
	private const string k_ErrorMessage = "Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]."; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; //Field offset: 0x10

	[NotNull]
	internal IPackageRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public override DependencyTree Tree
	{
		 get { } //Length: 70
		 set { } //Length: 194
	}

	public LockedPackageRegistry(IPackageRegistry registryToLock) { }

	[CompilerGenerated]
	internal IPackageRegistry get_Registry() { }

	public override DependencyTree get_Tree() { }

	public override void RegisterDependency(int packageTypeHash) { }

	public override void RegisterOptionalDependency(int packageTypeHash) { }

	public override CoreRegistration RegisterPackage(TPackage package) { }

	public override void RegisterProvision(int packageTypeHash) { }

	public override void set_Tree(DependencyTree value) { }

}

