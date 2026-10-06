namespace System.Globalization;

internal interface ISimpleCollator
{

	public int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	public SortKey GetSortKey(string source, CompareOptions options) { }

	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

}

