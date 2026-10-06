namespace Unity.Services.Core.Internal;

internal class DependencyTree
{
	public readonly Dictionary<Int32, IInitializablePackage> PackageTypeHashToInstance; //Field offset: 0x10
	public readonly Dictionary<Int32, Int32> ComponentTypeHashToPackageTypeHash; //Field offset: 0x18
	public readonly Dictionary<Int32, List`1<Int32>> PackageTypeHashToComponentTypeHashDependencies; //Field offset: 0x20
	public readonly Dictionary<Int32, IServiceComponent> ComponentTypeHashToInstance; //Field offset: 0x28

	internal DependencyTree() { }

	internal DependencyTree(Dictionary<Int32, IInitializablePackage> packageToInstance, Dictionary<Int32, Int32> componentToPackage, Dictionary<Int32, List`1<Int32>> packageToComponentDependencies, Dictionary<Int32, IServiceComponent> componentToInstance) { }

}

