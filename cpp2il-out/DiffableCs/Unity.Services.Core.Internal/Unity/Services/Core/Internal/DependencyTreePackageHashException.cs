namespace Unity.Services.Core.Internal;

internal class DependencyTreePackageHashException : HashException
{

	public DependencyTreePackageHashException(int hash) { }

	public DependencyTreePackageHashException(int hash, string message) { }

	public DependencyTreePackageHashException(int hash, string message, Exception inner) { }

}

