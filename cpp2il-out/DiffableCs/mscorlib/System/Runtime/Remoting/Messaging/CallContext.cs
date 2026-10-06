namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class CallContext
{

	private CallContext() { }

	public static object LogicalGetData(string name) { }

	public static void LogicalSetData(string name, object data) { }

	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}

