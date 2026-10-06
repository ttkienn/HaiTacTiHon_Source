namespace System.Reflection;

[Extension]
internal static class SignatureTypeExtensions
{

	[Extension]
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }

	[Extension]
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

}

