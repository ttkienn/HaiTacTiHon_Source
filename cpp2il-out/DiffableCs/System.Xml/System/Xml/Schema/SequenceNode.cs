namespace System.Xml.Schema;

internal sealed class SequenceNode : InteriorNode
{
	private struct SequenceConstructPosContext
	{
		public SequenceNode this_; //Field offset: 0x0
		public BitSet firstpos; //Field offset: 0x8
		public BitSet lastpos; //Field offset: 0x10
		public BitSet lastposLeft; //Field offset: 0x18
		public BitSet firstposRight; //Field offset: 0x20

		public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

	}


	public virtual bool IsNullable
	{
		 get { } //Length: 413
	}

	public SequenceNode() { }

	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public virtual bool get_IsNullable() { }

}

