//Type is in global namespace

public class Message
{
	public sbyte command; //Field offset: 0x10
	private myReader dis; //Field offset: 0x18
	private myWriter dos; //Field offset: 0x20
	public byte isOld; //Field offset: 0x28

	public Message(int command) { }

	public Message() { }

	public Message(sbyte command) { }

	public Message(sbyte command, SByte[] data) { }

	public void cleanup() { }

	public SByte[] getData() { }

	public myReader reader() { }

	public int readInt3Byte() { }

	public myWriter writer() { }

}

