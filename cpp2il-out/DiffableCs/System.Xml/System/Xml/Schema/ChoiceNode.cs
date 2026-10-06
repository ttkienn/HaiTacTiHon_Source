namespace System.Xml.Schema;

internal sealed class ChoiceNode : InteriorNode
{

	public virtual bool IsNullable
	{
		 get { } //Length: 142
	}

	public ChoiceNode() { }

	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public virtual bool get_IsNullable() { }

}

