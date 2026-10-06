namespace Unity.Services.Core.Internal;

internal static class CoreLogger
{
	internal const string Tag = "[ServicesCore]"; //Field offset: 0x0
	internal const string VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING"; //Field offset: 0x0
	private const string k_TelemetryLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING"; //Field offset: 0x0

	public static void Log(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	public static void LogError(object message) { }

	public static void LogException(Exception exception) { }

	[Conditional("ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING")]
	public static void LogTelemetry(object message) { }

	[Conditional("ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING")]
	public static void LogVerbose(object message) { }

	public static void LogWarning(object message) { }

}

