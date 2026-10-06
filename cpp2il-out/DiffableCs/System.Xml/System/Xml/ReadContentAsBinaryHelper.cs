namespace System.Xml;

internal class ReadContentAsBinaryHelper
{
	private enum State
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2,
	}

	private XmlReader reader; //Field offset: 0x10
	private State state; //Field offset: 0x18
	private int valueOffset; //Field offset: 0x1C
	private bool isEnd; //Field offset: 0x20

	internal void Finish() { }

	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	internal void Reset() { }

}

