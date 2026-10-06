//Type is in global namespace

public class Rms
{
	public static int status; //Field offset: 0x0
	private const int INTERVAL = 5; //Field offset: 0x0
	private const int MAXTIME = 500; //Field offset: 0x0
	public static SByte[] data; //Field offset: 0x8
	public static string filename; //Field offset: 0x10

	private static SByte[] __loadRMS(string filename) { }

	private static void __saveRMS(string filename, SByte[] data) { }

	private static SByte[] _loadRMS(string filename) { }

	private static void _saveRMS(string filename, SByte[] data) { }

	public Rms() { }

	public static string ByteArrayToString(Byte[] ba) { }

	public static void clearAll() { }

	public static void clearRMS() { }

	public static Byte[] convertSbyteToByte(SByte[] var) { }

	public static void deleteRecord(string name) { }

	public static void DeleteStorage(string path) { }

	public static string GetiPhoneDocumentsPath() { }

	public static string loadIP() { }

	public static SByte[] loadRMS(string filename) { }

	public static SByte[] loadRMS2(string filename) { }

	public static int loadRMSInt(string file) { }

	public static int loadRMSInt2(string file) { }

	public static string loadRMSString(string fileName) { }

	public static void saveIP(string strID) { }

	public static void saveRMS(string filename, SByte[] data) { }

	public static void saveRMS2(string filename, SByte[] data) { }

	public static void saveRMSInt(string file, int x) { }

	public static void saveRMSInt2(string file, int x) { }

	public static void saveRMSString(string filename, string data) { }

	public static Byte[] StringToByteArray(string hex) { }

	public static void update() { }

}

