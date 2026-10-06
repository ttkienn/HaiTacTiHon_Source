namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	internal static ILogger s_Logger; //Field offset: 0x8

	public static ILogger unityLogger
	{
		 get { } //Length: 79
	}

	private static Debug() { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition) { }

	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[ThreadSafe]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	public static ILogger get_unityLogger() { }

	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled() { }

	public static void Log(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	public static void LogError(object message) { }

	public static void LogError(object message, object context) { }

	public static void LogErrorFormat(string format, Object[] args) { }

	public static void LogErrorFormat(object context, string format, Object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, object context) { }

	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	public static void LogWarning(object message, object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarningFormat(string format, Object[] args) { }

	public static void LogWarningFormat(object context, string format, Object[] args) { }

}

