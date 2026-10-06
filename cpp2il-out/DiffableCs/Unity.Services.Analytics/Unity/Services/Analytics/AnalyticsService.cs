namespace Unity.Services.Analytics;

public static class AnalyticsService
{
	private const string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v2/projects/{0}/environments/{1}"; //Field offset: 0x0
	private static AnalyticsServiceInstance m_Instance; //Field offset: 0x0
	private static IDispatcherDebug m_DispatcherDebug; //Field offset: 0x8
	private static IBufferDebug m_BufferDebug; //Field offset: 0x10
	private static Action<String, String, DateTime, Byte[]> m_EventRecordedCallback; //Field offset: 0x18
	private static Action<HashSet`1<String>> m_EventsClearingCallback; //Field offset: 0x20
	private static Action<Byte[]> m_FlushStartedCallback; //Field offset: 0x28
	private static Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> m_FlushCompletedCallback; //Field offset: 0x30

	internal static IDispatcherDebug DispatcherDebug
	{
		internal get { } //Length: 55
	}

	public static IAnalyticsService Instance
	{
		 get { } //Length: 142
	}

	internal static bool IsInitialized
	{
		internal get { } //Length: 58
	}

	internal static IServiceDebug ServiceDebug
	{
		internal get { } //Length: 54
	}

	internal static IDispatcherDebug get_DispatcherDebug() { }

	public static IAnalyticsService get_Instance() { }

	internal static bool get_IsInitialized() { }

	internal static IServiceDebug get_ServiceDebug() { }

	internal static void Initialize(CoreRegistry registry) { }

	internal static void SubscribeDebugEvents(Action<String, String, DateTime, Byte[]> eventRecordedCallback, Action<HashSet`1<String>> eventsUploadingCallback, Action<Byte[]> flushStarted, Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> flushCompleted) { }

	internal static void TearDown() { }

	internal static void UnsubscribeDebugEvents() { }

}

