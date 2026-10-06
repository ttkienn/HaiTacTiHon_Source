namespace Unity.Services.Analytics;

internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug
{
	private const float k_AutoFlushPeriod = 60; //Field offset: 0x0
	private const float k_GameRunningPeriod = 60; //Field offset: 0x0
	private static bool s_Created; //Field offset: 0x0
	private static GameObject s_Container; //Field offset: 0x8
	private static AnalyticsContainer m_Instance; //Field offset: 0x10
	private float m_AutoFlushTime; //Field offset: 0x20
	private float m_GameRunningTime; //Field offset: 0x24
	private AnalyticsServiceInstance m_Service; //Field offset: 0x28

	private float AutoFlushPeriod
	{
		private get { } //Length: 116
	}

	internal static IContainerDebug ContainerDebug
	{
		internal get { } //Length: 55
	}

	public override float TimeUntilNextHeartbeat
	{
		 get { } //Length: 27
	}

	public AnalyticsContainer() { }

	private void CleanUp() { }

	internal static AnalyticsContainer CreateContainer() { }

	public override void Disable() { }

	public override void Enable() { }

	private float get_AutoFlushPeriod() { }

	internal static IContainerDebug get_ContainerDebug() { }

	public override float get_TimeUntilNextHeartbeat() { }

	public override void Initialize(AnalyticsServiceInstance service) { }

	private void OnApplicationPause(bool paused) { }

	private void Update() { }

}

