namespace MS.Internal.Xml.Cache;

internal abstract class XPathNodeHelper
{

	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

}

