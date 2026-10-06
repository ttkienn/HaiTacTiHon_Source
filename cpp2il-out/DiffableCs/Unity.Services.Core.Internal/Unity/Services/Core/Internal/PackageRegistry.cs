namespace Unity.Services.Core.Internal;

internal class PackageRegistry : IPackageRegistry
{
	[CompilerGenerated]
	private DependencyTree <Tree>k__BackingField; //Field offset: 0x10

	public override DependencyTree Tree
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public PackageRegistry(DependencyTree tree) { }

	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }

	[CompilerGenerated]
	public override DependencyTree get_Tree() { }

	public override void RegisterDependency(int packageTypeHash) { }

	public override void RegisterOptionalDependency(int packageTypeHash) { }

	public override CoreRegistration RegisterPackage(TPackage package) { }

	public override void RegisterProvision(int packageTypeHash) { }

	[CompilerGenerated]
	public override void set_Tree(DependencyTree value) { }

}

