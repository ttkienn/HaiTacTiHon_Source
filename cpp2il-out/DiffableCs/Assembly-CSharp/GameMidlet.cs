//Type is in global namespace

public class GameMidlet
{
	internal class connectOk : IKAction
	{

		public connectOk() { }

		public override void perform(string text) { }

	}

	public static string IP; //Field offset: 0x0
	public const byte JAVA = 0; //Field offset: 0x0
	public const byte ANDROID = 1; //Field offset: 0x0
	public const byte PC = 2; //Field offset: 0x0
	public const byte IOS = 3; //Field offset: 0x0
	public const byte WP = 4; //Field offset: 0x0
	public const byte ANDROID_STORE = 5; //Field offset: 0x0
	public const byte IOS_STORE = 6; //Field offset: 0x0
	public static int PORT; //Field offset: 0x8
	public static sbyte PROVIDER; //Field offset: 0xC
	public static byte DEVICE; //Field offset: 0xD
	public static byte ZOOM_IOS; //Field offset: 0xE
	public static GameCanvas gameCanvas; //Field offset: 0x10
	public static GameMidlet instance; //Field offset: 0x18
	public static bool isPC; //Field offset: 0x20
	public static string strLinkServerCheckENG; //Field offset: 0x28
	public static string strLinkServerCheck; //Field offset: 0x30
	public static string strLinkServerCheck2; //Field offset: 0x38
	public static string LONG; //Field offset: 0x40
	public static string LAT; //Field offset: 0x48
	public static String[] google_productIds; //Field offset: 0x50
	public static String[] google_listGems; //Field offset: 0x58
	public static String[] google_productIds_Eng; //Field offset: 0x60
	public static bool isTest; //Field offset: 0x68
	public static int numTest; //Field offset: 0x6C
	public static bool isBackWindowsPhone; //Field offset: 0x70
	private static connectOk achttp; //Field offset: 0x78

	private static GameMidlet() { }

	public GameMidlet() { }

	public void CheckPerGPS() { }

	public static void CheckThanhToan(string str) { }

	public static void closeApp() { }

	public static string connectHTTP(string Url) { }

	public static void delAllRms() { }

	public static void delRMS(string name) { }

	public static void delRMS() { }

	public void destroy() { }

	public void exit() { }

	public static string fixString(string chat) { }

	public static void flatForm(string url) { }

	public static string format(string strformat, String[] args) { }

	public static string format(string strformat, string str) { }

	public static string getThongBao() { }

	public void initGame() { }

	public static bool isIosNetwork() { }

	public static SByte[] loadRMS(string filename) { }

	public static string loginPlus() { }

	public static void makePurchase(string str) { }

	public void notifyDestroyed() { }

	public static DataInputStream openFile(string path) { }

	public static void openUrl(string url) { }

	public void platformRequest(string url) { }

	public void removeEditText() { }

	public static void saveRMS(string filename, SByte[] data) { }

	public static void sendSMS(string data, string to, iCommand successAction, iCommand failAction) { }

	public static string SubStr(string str, int begin, int end) { }

}

