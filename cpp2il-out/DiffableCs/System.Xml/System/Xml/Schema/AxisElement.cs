namespace System.Xml.Schema;

internal class AxisElement
{
	internal DoubleLinkAxis curNode; //Field offset: 0x10
	internal int rootDepth; //Field offset: 0x18
	internal int curDepth; //Field offset: 0x1C
	internal bool isMatch; //Field offset: 0x20

	internal DoubleLinkAxis CurNode
	{
		internal get { } //Length: 5
	}

	internal AxisElement(DoubleLinkAxis node, int depth) { }

	internal DoubleLinkAxis get_CurNode() { }

	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

	internal void MoveToParent(int depth, ForwardAxis parent) { }

	internal void SetDepth(int depth) { }

}

