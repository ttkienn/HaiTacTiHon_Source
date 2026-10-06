namespace Unity.Services.Core.Internal;

public class CircularDependencyException : ServicesInitializationException
{

	public CircularDependencyException() { }

	public CircularDependencyException(string message) { }

}

