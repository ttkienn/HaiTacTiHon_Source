namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Match>))]
[DefaultMember("Item")]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
{
	private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
	{
		private readonly MatchCollection _collection; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override Match Current
		{
			 get { } //Length: 124
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 124
		}

		internal Enumerator(MatchCollection collection) { }

		public override Match get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.IDisposable.Dispose() { }

	}

	private readonly Regex _regex; //Field offset: 0x10
	private readonly List<Match> _matches; //Field offset: 0x18
	private bool _done; //Field offset: 0x20
	private readonly string _input; //Field offset: 0x28
	private readonly int _beginning; //Field offset: 0x30
	private readonly int _length; //Field offset: 0x34
	private int _startat; //Field offset: 0x38
	private int _prevlen; //Field offset: 0x3C

	public override int Count
	{
		 get { } //Length: 82
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override Match Item
	{
		 get { } //Length: 174
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private override Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item
	{
		private get { } //Length: 20
		private set { } //Length: 78
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 20
		private set { } //Length: 78
	}

	internal MatchCollection(Regex regex, string input, int beginning, int length, int startat) { }

	internal MatchCollection() { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override void CopyTo(Match[] array, int arrayIndex) { }

	private void EnsureInitialized() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override Match get_Item(int i) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	private Match GetMatch(int i) { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	private override IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	private override Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

