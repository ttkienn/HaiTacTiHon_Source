namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[RequiredByNativeCode]
public static class AnalyticsSessionInfo
{
	internal sealed class IdentityTokenChanged : MulticastDelegate
	{

		public IdentityTokenChanged(object object, IntPtr method) { }

		public override void Invoke(string token) { }

	}

	internal sealed class SessionStateChanged : MulticastDelegate
	{

		public SessionStateChanged(object object, IntPtr method) { }

		public override void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SessionStateChanged sessionStateChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static IdentityTokenChanged identityTokenChanged; //Field offset: 0x8

	[RequiredByNativeCode]
	internal static void CallIdentityTokenChanged(string token) { }

	[RequiredByNativeCode]
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

}

