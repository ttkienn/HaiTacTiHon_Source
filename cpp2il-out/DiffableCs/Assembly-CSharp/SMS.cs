//Type is in global namespace

public class SMS
{
	private const int INTERVAL = 5; //Field offset: 0x0
	private const int MAXTIME = 500; //Field offset: 0x0
	private static int status; //Field offset: 0x0
	private static int _result; //Field offset: 0x4
	private static string _to; //Field offset: 0x8
	private static string _content; //Field offset: 0x10
	private static bool f; //Field offset: 0x18
	private static int time; //Field offset: 0x1C
	public static bool sendEnable; //Field offset: 0x20
	private static int time0; //Field offset: 0x24

	private static int __send(string content, string to) { }

	private static int _send(string content, string to) { }

	public SMS() { }

	private static void OnSMS() { }

	public static int send(string content, string to) { }

	public static void update() { }

}

