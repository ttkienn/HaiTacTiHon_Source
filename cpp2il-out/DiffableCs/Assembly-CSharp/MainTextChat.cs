//Type is in global namespace

public class MainTextChat
{
	public string text; //Field offset: 0x10
	public string textRight; //Field offset: 0x18
	public string textTime; //Field offset: 0x20
	public string nameText; //Field offset: 0x28
	public sbyte color; //Field offset: 0x30
	public sbyte typeLeftRight; //Field offset: 0x31
	public sbyte typeBg; //Field offset: 0x32
	public sbyte typeEvent; //Field offset: 0x33
	public sbyte lenghtText; //Field offset: 0x34
	public long timeBegin; //Field offset: 0x38
	public short IDMem; //Field offset: 0x40
	public short IdText; //Field offset: 0x42

	public MainTextChat(string text, sbyte color) { }

	public MainTextChat(string text, string textRight, sbyte color, sbyte colorBg, sbyte typeBg) { }

	public void setTimePaint() { }

}

