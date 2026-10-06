namespace Unity.Services.Core.Internal;

internal struct DependencyTreeInitializeOrderSorter
{
	private enum ExplorationMark
	{
		None = 0,
		Viewed = 1,
		Sorted = 2,
	}

	public readonly DependencyTree Tree; //Field offset: 0x0
	public readonly ICollection<Int32> Target; //Field offset: 0x8
	private Dictionary<Int32, ExplorationMark> m_PackageTypeHashExplorationHistory; //Field offset: 0x10

	public DependencyTreeInitializeOrderSorter(DependencyTree tree, ICollection<Int32> target) { }

	private IEnumerable<Int32> GetDependencyTypeHashesFor(int packageTypeHash) { }

	private IReadOnlyCollection<Int32> GetPackageTypeHashes() { }

	private int GetPackageTypeHashFor(int componentTypeHash) { }

	private void MarkPackage(int packageTypeHash, ExplorationMark mark) { }

	private void RemoveUnprovidedOptionalDependencies(IList<Int32> dependencyTypeHashes) { }

	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	public void SortRegisteredPackagesIntoTarget() { }

	private void SortTreeThrough(int packageTypeHash) { }

	private void SortTreeThrough(IEnumerable<Int32> dependencyTypeHashes) { }

}

