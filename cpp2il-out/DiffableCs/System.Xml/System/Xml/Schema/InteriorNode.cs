namespace System.Xml.Schema;

internal abstract class InteriorNode : SyntaxTreeNode
{
	private SyntaxTreeNode leftChild; //Field offset: 0x10
	private SyntaxTreeNode rightChild; //Field offset: 0x18

	public SyntaxTreeNode LeftChild
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public SyntaxTreeNode RightChild
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	protected InteriorNode() { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public SyntaxTreeNode get_LeftChild() { }

	public SyntaxTreeNode get_RightChild() { }

	public void set_LeftChild(SyntaxTreeNode value) { }

	public void set_RightChild(SyntaxTreeNode value) { }

}

