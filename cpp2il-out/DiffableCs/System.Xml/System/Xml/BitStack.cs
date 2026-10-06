namespace System.Xml;

internal class BitStack
{
	private UInt32[] bitStack; //Field offset: 0x10
	private int stackPos; //Field offset: 0x18
	private uint curr; //Field offset: 0x1C

	public BitStack() { }

	public bool PeekBit() { }

	public bool PopBit() { }

	private void PopCurr() { }

	public void PushBit(bool bit) { }

	private void PushCurr() { }

}

