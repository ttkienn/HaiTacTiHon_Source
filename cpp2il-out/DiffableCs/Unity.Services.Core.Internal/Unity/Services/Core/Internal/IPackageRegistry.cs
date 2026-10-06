namespace Unity.Services.Core.Internal;

internal interface IPackageRegistry
{

	[CanBeNull]
	public DependencyTree Tree
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public DependencyTree get_Tree() { }

	public void RegisterDependency(int packageTypeHash) { }

	public void RegisterOptionalDependency(int packageTypeHash) { }

	public CoreRegistration RegisterPackage(TPackage package) { }

	public void RegisterProvision(int packageTypeHash) { }

	public void set_Tree(DependencyTree value) { }

}

