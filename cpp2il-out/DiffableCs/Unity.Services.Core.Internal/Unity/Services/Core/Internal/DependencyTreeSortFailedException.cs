namespace Unity.Services.Core.Internal;

internal class DependencyTreeSortFailedException : Exception
{

	public DependencyTreeSortFailedException(DependencyTree tree, ICollection<Int32> target) { }

	public DependencyTreeSortFailedException(DependencyTree tree, ICollection<Int32> target, Exception inner) { }

	private static string CreateExceptionMessage(DependencyTree tree, ICollection<Int32> target, Exception inner = null) { }

}

