namespace UnityEngine;

internal class AndroidReflection
{
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; //Field offset: 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; //Field offset: 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; //Field offset: 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; //Field offset: 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; //Field offset: 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; //Field offset: 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; //Field offset: 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; //Field offset: 0x38

	private static AndroidReflection() { }

	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	public static IntPtr GetFieldClass(IntPtr field) { }

	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	public static string GetFieldSignature(IntPtr field) { }

	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	public static bool IsAssignableFrom(Type t, Type from) { }

	public static bool IsPrimitive(Type t) { }

	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

}

