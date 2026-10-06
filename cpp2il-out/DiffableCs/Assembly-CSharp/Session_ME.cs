//Type is in global namespace

public class Session_ME : ISession
{
	private class MessageCollector
	{

		public MessageCollector() { }

		private void getKey(Message message) { }

		private Message readMessage() { }

		public void run() { }

	}

	internal class Sender
	{
		public List<Message> sendingMessage; //Field offset: 0x10

		public Sender() { }

		public void AddMessage(Message message) { }

		public void run() { }

	}

	protected static Session_ME instance; //Field offset: 0x0
	private static NetworkStream dataStream; //Field offset: 0x8
	private static BinaryReader dis; //Field offset: 0x10
	private static BinaryWriter dos; //Field offset: 0x18
	public static IMessageHandler messageHandler; //Field offset: 0x20
	private static TcpClient sc; //Field offset: 0x28
	public static bool connected; //Field offset: 0x30
	public static bool connecting; //Field offset: 0x31
	public static bool isStart; //Field offset: 0x32
	private static Sender sender; //Field offset: 0x38
	public static Thread initThread; //Field offset: 0x40
	public static Thread collectorThread; //Field offset: 0x48
	public static Thread sendThread; //Field offset: 0x50
	public static int sendByteCount; //Field offset: 0x58
	public static int recvByteCount; //Field offset: 0x5C
	private static bool getKeyComplete; //Field offset: 0x60
	public static SByte[] key; //Field offset: 0x68
	private static sbyte curR; //Field offset: 0x70
	private static sbyte curW; //Field offset: 0x71
	private static int timeConnected; //Field offset: 0x74
	public static string strRecvByteCount; //Field offset: 0x78
	public static bool isCancel; //Field offset: 0x80
	public static long timeStart; //Field offset: 0x88
	private static string test; //Field offset: 0x90
	public static mVector recieveMsg; //Field offset: 0x98
	private string host; //Field offset: 0x10
	private int port; //Field offset: 0x18

	private static Session_ME() { }

	public Session_ME() { }

	private static void cleanNetwork() { }

	public void clearSendingMessage() { }

	public override void close() { }

	public override void connect(string host, int port) { }

	public static byte convertSbyteToByte(sbyte var) { }

	public static Byte[] convertSbyteToByte(SByte[] var) { }

	public static int currentTimeMillis() { }

	public void doConnect(string host, int port) { }

	private static void doSendMessage(Message m) { }

	public static Session_ME gI() { }

	public override bool isConnected() { }

	private void NetworkInit() { }

	public static void onRecieveMsg(Message msg) { }

	public static sbyte readKey(sbyte b) { }

	public override void sendMessage(Message message) { }

	public override void setHandler(IMessageHandler msgHandler) { }

	public static void update() { }

	public static sbyte writeKey(sbyte b) { }

}

