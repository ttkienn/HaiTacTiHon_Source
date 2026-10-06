namespace System.Reflection;

internal struct MonoMethodInfo
{
	private Type parent; //Field offset: 0x0
	private Type ret; //Field offset: 0x8
	internal MethodAttributes attrs; //Field offset: 0x10
	internal MethodImplAttributes iattrs; //Field offset: 0x14
	private CallingConventions callconv; //Field offset: 0x18

	private static int get_method_attributes(IntPtr handle) { }

	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	internal static Type GetDeclaringType(IntPtr handle) { }

	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }

	internal static Type GetReturnType(IntPtr handle) { }

}

