//Type is in global namespace

public class DataInputStream
{
	private const int INTERVAL = 5; //Field offset: 0x0
	private const int MAXTIME = 500; //Field offset: 0x0
	public static DataInputStream istemp; //Field offset: 0x0
	private static int status; //Field offset: 0x8
	private static string filenametemp; //Field offset: 0x10
	public myReader r; //Field offset: 0x10

	private static DataInputStream __getResourceAsStream(string filename) { }

	private static DataInputStream _getResourceAsStream(string filename) { }

	public DataInputStream(ByteArrayInputStream bis) { }

	public DataInputStream(string filename) { }

	public DataInputStream(SByte[] data) { }

	public int available() { }

	public void close() { }

	public void Close() { }

	public static DataInputStream getResourceAsStream(string filename) { }

	public void read(ref SByte[] data) { }

	public int read() { }

	internal void read(ref SByte[] byteData, int p, int size) { }

	public bool readBoolean() { }

	public sbyte readByte() { }

	public void readFully(ref SByte[] data) { }

	public int readInt() { }

	public long readLong() { }

	public short readShort() { }

	public int readUnsignedByte() { }

	public int readUnsignedShort() { }

	public string readUTF() { }

	public static void update() { }

}

