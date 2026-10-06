namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[UsedByNativeCode]
public static class AndroidJNIHelper
{

	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	public static IntPtr Box(int value) { }

	public static IntPtr Box(bool value) { }

	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static void CreateJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

}

