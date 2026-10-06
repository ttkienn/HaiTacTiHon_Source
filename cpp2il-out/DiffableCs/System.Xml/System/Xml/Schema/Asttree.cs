namespace System.Xml.Schema;

internal class Asttree
{
	private ArrayList _fAxisArray; //Field offset: 0x10
	private string _xpathexpr; //Field offset: 0x18
	private bool _isField; //Field offset: 0x20
	private XmlNamespaceManager _nsmgr; //Field offset: 0x28

	internal ArrayList SubtreeArray
	{
		internal get { } //Length: 5
	}

	public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	internal ArrayList get_SubtreeArray() { }

	internal static bool IsAttribute(Axis ast) { }

	private static bool IsDescendantOrSelf(Axis ast) { }

	private static bool IsNameTest(Axis ast) { }

	internal static bool IsSelf(Axis ast) { }

	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

