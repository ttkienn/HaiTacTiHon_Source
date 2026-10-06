namespace System.Dynamic.Utils;

[Extension]
internal static class TypeExtensions
{
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; //Field offset: 0x0

	private static TypeExtensions() { }

	[Extension]
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	[Extension]
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

}

