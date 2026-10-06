namespace System.Net;

internal sealed class NetEventSource : EventSource
{
	internal class Keywords
	{
		public const EventKeywords Default = 1; //Field offset: 0x0
		public const EventKeywords Debug = 2; //Field offset: 0x0
		public const EventKeywords EnterExit = 4; //Field offset: 0x0

	}

	public static readonly NetEventSource Log; //Field offset: 0x0

	public static bool IsEnabled
	{
		 get { } //Length: 94
	}

	private static NetEventSource() { }

	public NetEventSource() { }

	[Event(3, Level = EventLevel::Informational (4), Keywords = 1, Message = "[{2}]<-->[{3}]")]
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	[NonEvent]
	public static void Associate(object first, object second, string memberName = null) { }

	[Event(6, Level = EventLevel::Critical (1), Keywords = 2)]
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	public static void Enter(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName = null) { }

	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, string memberName = null) { }

	[Event(1, Level = EventLevel::Informational (4), Keywords = 4)]
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	public static void Error(object thisOrContextObject, object message, string memberName = null) { }

	[Event(5, Level = EventLevel::Warning (3), Keywords = 1)]
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	public static void Exit(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[NonEvent]
	public static void Exit(object thisOrContextObject, object arg0, string memberName = null) { }

	[Event(2, Level = EventLevel::Informational (4), Keywords = 4)]
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	public static void Fail(object thisOrContextObject, object message, string memberName = null) { }

	[NonEvent]
	public static object Format(object value) { }

	[NonEvent]
	private static string Format(FormattableString s) { }

	public static bool get_IsEnabled() { }

	[NonEvent]
	public static int GetHashCode(object value) { }

	[NonEvent]
	public static string IdOf(object value) { }

	[NonEvent]
	public static void Info(object thisOrContextObject, object message, string memberName = null) { }

	[NonEvent]
	public static void Info(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Event(4, Level = EventLevel::Informational (4), Keywords = 1)]
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

}

