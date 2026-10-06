namespace Unity.Services.Analytics;

internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IServiceDebug
{
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion"; //Field offset: 0x0
	private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup"; //Field offset: 0x0
	private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged"; //Field offset: 0x0
	internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked"; //Field offset: 0x0
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; //Field offset: 0x10
	private readonly TransactionCurrencyConverter converter; //Field offset: 0x18
	private readonly IIdentityManager m_UserIdentity; //Field offset: 0x20
	private readonly ISessionManager m_Session; //Field offset: 0x28
	private readonly IDataGenerator m_DataGenerator; //Field offset: 0x30
	private readonly ICoreStatsHelper m_CoreStatsHelper; //Field offset: 0x38
	private readonly IDispatcher m_DataDispatcher; //Field offset: 0x40
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; //Field offset: 0x48
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; //Field offset: 0x50
	private readonly IAnalyticsContainer m_Container; //Field offset: 0x58
	internal IBuffer m_DataBuffer; //Field offset: 0x60
	private int m_BufferLengthAtLastGameRunning; //Field offset: 0x68
	private DateTime m_ApplicationPauseTime; //Field offset: 0x70
	private bool m_IsActive; //Field offset: 0x78
	private bool m_StartUpEventsRecorded; //Field offset: 0x79

	internal bool Active
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal int AutoflushPeriodMultiplier
	{
		internal get { } //Length: 99
	}

	public override bool IsActive
	{
		 get { } //Length: 5
	}

	public override string PrivacyUrl
	{
		 get { } //Length: 44
	}

	public override string SessionID
	{
		 get { } //Length: 70
	}

	public override IIdentityManager UserIdentity
	{
		 get { } //Length: 5
	}

	internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session) { }

	private void Activate() { }

	internal void ApplicationPaused(bool paused) { }

	internal void ApplicationQuit() { }

	public override long ConvertCurrencyToMinorUnits(string currencyCode, double value) { }

	public override void CustomData(string eventName, IDictionary<String, Object> eventParams, Nullable<Int32> eventVersion, bool isStandardEvent, string callingMethodIdentifier) { }

	public void CustomData(string eventName, IDictionary<String, Object> eventParams) { }

	public void CustomData(string eventName) { }

	private void DataDeletionCompleted() { }

	private void Deactivate() { }

	internal void DeactivateWithDataDeletionRequest() { }

	public override void Flush() { }

	internal bool get_Active() { }

	internal int get_AutoflushPeriodMultiplier() { }

	public override bool get_IsActive() { }

	public override string get_PrivacyUrl() { }

	public override string get_SessionID() { }

	public override IIdentityManager get_UserIdentity() { }

	public override string GetAnalyticsUserID() { }

	private void PlayerChanged() { }

	public override void RecordEvent(Event e) { }

	public override void RecordEvent(string name) { }

	internal void RecordEvent(Event e, string callingMethodIdentifier) { }

	internal void RecordGameRunningIfNecessary() { }

	private void RecordStartupEvents(string callingId) { }

	public override void RequestDataDeletion() { }

	internal void ResumeDataDeletionIfNecessary() { }

	internal void set_Active(bool value) { }

	public override void StartDataCollection() { }

	public override void StopDataCollection() { }

}

