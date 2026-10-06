namespace System.Runtime.Serialization;

[ComVisible(True)]
public static class FormatterServices
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

	}

	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; //Field offset: 0x0
	private static bool unsafeTypeForwardersIsEnabled; //Field offset: 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; //Field offset: 0x9
	private static readonly Type[] advancedTypes; //Field offset: 0x10
	private static Binder s_binder; //Field offset: 0x18

	private static FormatterServices() { }

	private static bool CheckSerializable(RuntimeType type) { }

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	internal static string GetClrTypeFullName(Type type) { }

	private static string GetClrTypeFullNameForArray(Type type) { }

	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

	private static bool GetEnableUnsafeTypeForwarders() { }

	public static Object[] GetObjectData(object obj, MemberInfo[] members) { }

	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	public static object GetUninitializedObject(Type type) { }

	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	private static object nativeGetUninitializedObject(RuntimeType type) { }

	public static object PopulateObjectMembers(object obj, MemberInfo[] members, Object[] data) { }

	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	internal static bool UnsafeTypeForwardersIsEnabled() { }

}

