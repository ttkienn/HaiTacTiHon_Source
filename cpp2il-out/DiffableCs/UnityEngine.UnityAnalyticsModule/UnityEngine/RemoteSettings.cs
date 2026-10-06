namespace UnityEngine;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
public static class RemoteSettings
{
	internal sealed class UpdatedEventHandler : MulticastDelegate
	{

		public UpdatedEventHandler(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UpdatedEventHandler Updated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action BeforeFetchFromServer; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean, Boolean, Int32> Completed; //Field offset: 0x10

	[RequiredByNativeCode]
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

	[RequiredByNativeCode]
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

}

