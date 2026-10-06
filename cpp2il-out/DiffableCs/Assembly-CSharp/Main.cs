//Type is in global namespace

public class Main : MonoBehaviour
{
	public static Main main; //Field offset: 0x0
	public const sbyte IP_JB = 3; //Field offset: 0x0
	public const sbyte WINDOWSPHONE = 6; //Field offset: 0x0
	public const sbyte PC_VERSION = 4; //Field offset: 0x0
	public const sbyte IP_APPSTORE = 5; //Field offset: 0x0
	public static mGraphics g; //Field offset: 0x8
	public static GameMidlet midlet; //Field offset: 0x10
	public static string res; //Field offset: 0x18
	public static string mainThreadName; //Field offset: 0x20
	public static bool started; //Field offset: 0x28
	public static bool isIpod; //Field offset: 0x29
	public static bool isIphone4; //Field offset: 0x2A
	public static bool isWindowsPhone; //Field offset: 0x2B
	public static bool isIPhone; //Field offset: 0x2C
	public static bool IphoneVersionApp; //Field offset: 0x2D
	public static string IMEI; //Field offset: 0x30
	public static int versionIp; //Field offset: 0x38
	public static int numberQuit; //Field offset: 0x3C
	public static int typeClient; //Field offset: 0x40
	public static int waitTick; //Field offset: 0x44
	public static int f; //Field offset: 0x48
	public static bool isResume; //Field offset: 0x4C
	public static bool isMiniApp; //Field offset: 0x4D
	public static bool isQuitApp; //Field offset: 0x4E
	public static int a; //Field offset: 0x50
	public static bool isCompactDevice; //Field offset: 0x54
	private Queue<IEnumerator> jobs; //Field offset: 0x20
	private int updateCount; //Field offset: 0x28
	private int paintCount; //Field offset: 0x2C
	private int count; //Field offset: 0x30
	private bool isRun; //Field offset: 0x34
	private int valueKey; //Field offset: 0x38
	private Vector2 lastMousePos; //Field offset: 0x3C

	private static Main() { }

	public Main() { }

	internal void AddJob(IEnumerator newJob) { }

	private void Awake() { }

	public static bool checkCanSendSMS() { }

	private void checkInput() { }

	public static void closeKeyBoard() { }

	public static bool detectCompactDevice() { }

	public void doClearRMS() { }

	public static void exit() { }

	private void FixedUpdate() { }

	public string GetMacAddress() { }

	private void OnApplicationPause(bool paused) { }

	private void OnApplicationQuit() { }

	private void OnGUI() { }

	private void OnHideUnity(bool isGameShown) { }

	public static void setBackupIcloud(string path) { }

	private void SetInit() { }

	public void setsizeChange() { }

	private void Start() { }

	private void Update() { }

}

