namespace UnityEngine.Purchasing.Extension;

internal class UnityUtil : IUtil
{
	private static readonly List<RuntimePlatform> s_PcControlledPlatforms; //Field offset: 0x0
	internal const string ObsoleteUpgradeToIAPV5Message = "This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5"; //Field offset: 0x0
	private IThreadUtils m_ThreadUtils; //Field offset: 0x10
	private IMonoBehaviourUtil m_MonoBehaviourUtils; //Field offset: 0x18
	private readonly List<Action`1<Boolean>> pauseListeners; //Field offset: 0x20

	public override string cloudProjectId
	{
		 get { } //Length: 64
	}

	public override DateTime currentTime
	{
		 get { } //Length: 64
	}

	public override string deviceModel
	{
		 get { } //Length: 7
	}

	public override string deviceName
	{
		 get { } //Length: 7
	}

	public override DeviceType deviceType
	{
		 get { } //Length: 7
	}

	public override string deviceUniqueIdentifier
	{
		 get { } //Length: 7
	}

	public override string gameVersion
	{
		 get { } //Length: 64
	}

	public override bool isEditor
	{
		 get { } //Length: 64
	}

	public override string operatingSystem
	{
		 get { } //Length: 7
	}

	public override string persistentDataPath
	{
		 get { } //Length: 64
	}

	public override RuntimePlatform platform
	{
		 get { } //Length: 64
	}

	public override float screenDpi
	{
		 get { } //Length: 7
	}

	public override int screenHeight
	{
		 get { } //Length: 7
	}

	public override string screenOrientation
	{
		 get { } //Length: 81
	}

	public override int screenWidth
	{
		 get { } //Length: 7
	}

	public override ulong sessionId
	{
		 get { } //Length: 80
	}

	public override string unityVersion
	{
		 get { } //Length: 64
	}

	public override string userId
	{
		 get { } //Length: 80
	}

	private static UnityUtil() { }

	[Preserve]
	public UnityUtil(IThreadUtils threadUtils, IMonoBehaviourUtil monoBehaviorUtil) { }

	public override void AddPauseListener(Action<Boolean> runnable) { }

	public override string get_cloudProjectId() { }

	public override DateTime get_currentTime() { }

	public override string get_deviceModel() { }

	public override string get_deviceName() { }

	public override DeviceType get_deviceType() { }

	public override string get_deviceUniqueIdentifier() { }

	public override string get_gameVersion() { }

	public override bool get_isEditor() { }

	public override string get_operatingSystem() { }

	public override string get_persistentDataPath() { }

	public override RuntimePlatform get_platform() { }

	public override float get_screenDpi() { }

	public override int get_screenHeight() { }

	public override string get_screenOrientation() { }

	public override int get_screenWidth() { }

	public override ulong get_sessionId() { }

	public override string get_unityVersion() { }

	public override string get_userId() { }

	public override T[] GetAnyComponentsOfType() { }

	public override object GetWaitForSeconds(int seconds) { }

	public override bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	public static bool PcPlatform() { }

	public override void RunOnMainThread(Action runnable) { }

	private override object Uniject.IUtil.InitiateCoroutine(IEnumerator start) { }

	private override void Uniject.IUtil.InitiateCoroutine(IEnumerator start, int delay) { }

}

