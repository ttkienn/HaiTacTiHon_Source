namespace System.Xml.Schema;

internal class ActiveAxis
{
	private int _currentDepth; //Field offset: 0x10
	private bool _isActive; //Field offset: 0x14
	private Asttree _axisTree; //Field offset: 0x18
	private ArrayList _axisStack; //Field offset: 0x20

	public int CurrentDepth
	{
		 get { } //Length: 191
	}

	internal ActiveAxis(Asttree axisTree) { }

	public override bool EndElement(string localname, string URN) { }

	public int get_CurrentDepth() { }

	public bool MoveToAttribute(string localname, string URN) { }

	public bool MoveToStartElement(string localname, string URN) { }

	internal void Reactivate() { }

}

