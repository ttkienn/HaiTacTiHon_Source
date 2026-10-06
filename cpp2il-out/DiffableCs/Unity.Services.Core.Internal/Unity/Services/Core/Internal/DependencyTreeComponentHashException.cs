namespace Unity.Services.Core.Internal;

internal class DependencyTreeComponentHashException : HashException
{

	public DependencyTreeComponentHashException(int hash) { }

	public DependencyTreeComponentHashException(int hash, string message) { }

	public DependencyTreeComponentHashException(int hash, string message, Exception inner) { }

}

