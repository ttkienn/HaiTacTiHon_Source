//Type is in global namespace

public class idSaveImage
{
	public short id; //Field offset: 0x10
	public SByte[] mbytImage; //Field offset: 0x18
	public string name; //Field offset: 0x20

	public idSaveImage(short id, SByte[] msbyte) { }

	public idSaveImage(string name, SByte[] msbyte) { }

}

