namespace UnityEngine;

public class AndroidJavaProxy
{
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; //Field offset: 0x0
	private static readonly IntPtr s_HashCodeMethodID; //Field offset: 0x8
	public readonly AndroidJavaClass javaInterface; //Field offset: 0x10
	internal IntPtr proxyObject; //Field offset: 0x18

	private static AndroidJavaProxy() { }

	public AndroidJavaProxy(string javaInterface) { }

	public AndroidJavaProxy(AndroidJavaClass javaInterface) { }

	public override bool equals(AndroidJavaObject obj) { }

	protected virtual void Finalize() { }

	internal AndroidJavaObject GetProxyObject() { }

	internal IntPtr GetRawProxy() { }

	public override int hashCode() { }

	public override AndroidJavaObject Invoke(string methodName, Object[] args) { }

	public override AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	public override string toString() { }

}

