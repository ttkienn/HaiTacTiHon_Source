//Type is in global namespace

public class myReader
{
	private static string fileName; //Field offset: 0x0
	private static int status; //Field offset: 0x8
	public SByte[] buffer; //Field offset: 0x10
	private int posRead; //Field offset: 0x18
	private int posMark; //Field offset: 0x1C

	public myReader() { }

	public myReader(SByte[] data) { }

	public myReader(string filename) { }

	public int available() { }

	public void close() { }

	public void Close() { }

	public static Byte[] convertSbyteToByte(SByte[] var) { }

	public static byte convertSbyteToByte(sbyte var) { }

	public void mark(int readlimit) { }

	public int read(ref SByte[] data) { }

	public int read() { }

	public void read(ref SByte[] data, int arg1, int arg2) { }

	public bool readBool() { }

	public bool readBoolean() { }

	public sbyte readByte() { }

	public void readFully(ref SByte[] data) { }

	public int readInt() { }

	public long readLong() { }

	public sbyte readsbyte() { }

	public sbyte readSByte() { }

	public short readShort() { }

	public string readString() { }

	public string readStringUTF() { }

	public byte readUnsignedByte() { }

	public ushort readUnsignedShort() { }

	public string readUTF() { }

	public void reset() { }

}

