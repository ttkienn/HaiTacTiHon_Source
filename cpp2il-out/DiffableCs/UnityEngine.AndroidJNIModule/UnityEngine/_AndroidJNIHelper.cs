namespace UnityEngine;

[UsedByNativeCode]
internal sealed class _AndroidJNIHelper
{

	public static AndroidJavaObject Box(object obj) { }

	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	public static IntPtr ConvertToJNIArray(Array array) { }

	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static void CreateJNIArgArray(Object[] args, Span<jvalue> ret) { }

	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	public static string GetSignature(Object[] args) { }

	public static string GetSignature(object obj) { }

	public static string GetSignature(Object[] args) { }

	[RequiredByNativeCode]
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	public static object Unbox(AndroidJavaObject obj) { }

	public static object UnboxArray(AndroidJavaObject obj) { }

}

