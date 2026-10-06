namespace System.Xml.Schema;

internal class IdRefNode
{
	internal string Id; //Field offset: 0x10
	internal int LineNo; //Field offset: 0x18
	internal int LinePos; //Field offset: 0x1C
	internal IdRefNode Next; //Field offset: 0x20

	internal IdRefNode(IdRefNode next, string id, int lineNo, int linePos) { }

}

