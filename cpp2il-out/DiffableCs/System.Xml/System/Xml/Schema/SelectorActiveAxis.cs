namespace System.Xml.Schema;

internal class SelectorActiveAxis : ActiveAxis
{
	private ConstraintStruct cs; //Field offset: 0x28
	private ArrayList KSs; //Field offset: 0x30
	private int KSpointer; //Field offset: 0x38

	public int lastDepth
	{
		 get { } //Length: 162
	}

	public SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs) { }

	public virtual bool EndElement(string localname, string URN) { }

	public int get_lastDepth() { }

	public KeySequence PopKS() { }

	public int PushKS(int errline, int errcol) { }

}

