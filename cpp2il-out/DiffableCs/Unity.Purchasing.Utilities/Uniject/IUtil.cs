namespace Uniject;

internal interface IUtil
{

	public string cloudProjectId
	{
		 get { } //Length: 0
	}

	public DateTime currentTime
	{
		 get { } //Length: 0
	}

	public string deviceModel
	{
		 get { } //Length: 0
	}

	public string deviceName
	{
		 get { } //Length: 0
	}

	public DeviceType deviceType
	{
		 get { } //Length: 0
	}

	public string deviceUniqueIdentifier
	{
		 get { } //Length: 0
	}

	public string gameVersion
	{
		 get { } //Length: 0
	}

	public bool isEditor
	{
		 get { } //Length: 0
	}

	public string operatingSystem
	{
		 get { } //Length: 0
	}

	public string persistentDataPath
	{
		 get { } //Length: 0
	}

	public RuntimePlatform platform
	{
		 get { } //Length: 0
	}

	public float screenDpi
	{
		 get { } //Length: 0
	}

	public int screenHeight
	{
		 get { } //Length: 0
	}

	public string screenOrientation
	{
		 get { } //Length: 0
	}

	public int screenWidth
	{
		 get { } //Length: 0
	}

	public ulong sessionId
	{
		 get { } //Length: 0
	}

	public string unityVersion
	{
		 get { } //Length: 0
	}

	public string userId
	{
		 get { } //Length: 0
	}

	public void AddPauseListener(Action<Boolean> runnable) { }

	public string get_cloudProjectId() { }

	public DateTime get_currentTime() { }

	public string get_deviceModel() { }

	public string get_deviceName() { }

	public DeviceType get_deviceType() { }

	public string get_deviceUniqueIdentifier() { }

	public string get_gameVersion() { }

	public bool get_isEditor() { }

	public string get_operatingSystem() { }

	public string get_persistentDataPath() { }

	public RuntimePlatform get_platform() { }

	public float get_screenDpi() { }

	public int get_screenHeight() { }

	public string get_screenOrientation() { }

	public int get_screenWidth() { }

	public ulong get_sessionId() { }

	public string get_unityVersion() { }

	public string get_userId() { }

	public T[] GetAnyComponentsOfType() { }

	public object GetWaitForSeconds(int seconds) { }

	public object InitiateCoroutine(IEnumerator start) { }

	public void InitiateCoroutine(IEnumerator start, int delayInSeconds) { }

	public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	public void RunOnMainThread(Action runnable) { }

}

