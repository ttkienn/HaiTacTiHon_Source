namespace System.Dynamic;

internal class ExpandoClass
{
	internal static readonly ExpandoClass Empty; //Field offset: 0x0
	private readonly String[] _keys; //Field offset: 0x10
	private readonly int _hashCode; //Field offset: 0x18
	private Dictionary<Int32, List`1<WeakReference>> _transitions; //Field offset: 0x20

	internal String[] Keys
	{
		internal get { } //Length: 5
	}

	private static ExpandoClass() { }

	internal ExpandoClass() { }

	internal ExpandoClass(String[] keys, int hashCode) { }

	internal ExpandoClass FindNewClass(string newKey) { }

	internal String[] get_Keys() { }

	private List<WeakReference> GetTransitionList(int hashCode) { }

	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	internal int GetValueIndexCaseSensitive(string name) { }

}

