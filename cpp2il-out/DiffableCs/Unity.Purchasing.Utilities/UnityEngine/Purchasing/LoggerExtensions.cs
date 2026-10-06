namespace UnityEngine.Purchasing;

[Extension]
internal static class LoggerExtensions
{
	private const string k_IAPLogTag = "InAppPurchasing"; //Field offset: 0x0

	[Extension]
	public static void LogIAP(ILogger logger, string message) { }

	[Extension]
	public static void LogIAPError(ILogger logger, string message) { }

	[Extension]
	public static void LogIAPException(ILogger logger, Exception exception) { }

	[Extension]
	public static void LogIAPWarning(ILogger logger, string message) { }

}

