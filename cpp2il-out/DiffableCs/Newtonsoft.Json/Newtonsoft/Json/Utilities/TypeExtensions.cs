namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class TypeExtensions
{

	[Extension]
	public static Assembly Assembly(Type type) { }

	[Extension]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Extension]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Extension]
	public static Type BaseType(Type type) { }

	[Extension]
	public static bool ContainsGenericParameters(Type type) { }

	[Extension]
	public static bool ImplementInterface(Type type, Type interfaceType) { }

	[Extension]
	public static bool IsAbstract(Type type) { }

	[Extension]
	public static bool IsClass(Type type) { }

	[Extension]
	public static bool IsEnum(Type type) { }

	[Extension]
	public static bool IsGenericType(Type type) { }

	[Extension]
	public static bool IsGenericTypeDefinition(Type type) { }

	[Extension]
	public static bool IsInterface(Type type) { }

	[Extension]
	public static bool IsPrimitive(Type type) { }

	[Extension]
	public static bool IsSealed(Type type) { }

	[Extension]
	public static bool IsValueType(Type type) { }

	[Extension]
	public static bool IsVisible(Type type) { }

	[Extension]
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Extension]
	public static MethodInfo Method(Delegate d) { }

}

