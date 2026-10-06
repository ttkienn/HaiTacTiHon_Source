namespace UnityEngine;

[ExcludeFromDocs]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
public class RemoteConfigSettings
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> Updated; //Field offset: 0x18

	[RequiredByNativeCode]
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }

}

