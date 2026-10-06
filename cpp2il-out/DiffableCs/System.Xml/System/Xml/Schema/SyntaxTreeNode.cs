namespace System.Xml.Schema;

internal abstract class SyntaxTreeNode
{

	public abstract bool IsNullable
	{
		 get { } //Length: 0
	}

	public override bool IsRangeNode
	{
		 get { } //Length: 3
	}

	protected SyntaxTreeNode() { }

	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public abstract bool get_IsNullable() { }

	public override bool get_IsRangeNode() { }

}

