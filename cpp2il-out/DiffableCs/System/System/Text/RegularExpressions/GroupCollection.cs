namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Group>))]
[DefaultMember("Item")]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
{
	private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
	{
		private readonly GroupCollection _collection; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override Group Current
		{
			 get { } //Length: 151
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 151
		}

		internal Enumerator(GroupCollection collection) { }

		public override Group get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.IDisposable.Dispose() { }

	}

	private readonly Match _match; //Field offset: 0x10
	private readonly Hashtable _captureMap; //Field offset: 0x18
	private Group[] _groups; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 35
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override Group Item
	{
		 get { } //Length: 8
	}

	public Group Item
	{
		 get { } //Length: 422
	}

	public override object SyncRoot
	{
		 get { } //Length: 5
	}

	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item
	{
		private get { } //Length: 8
		private set { } //Length: 78
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 8
		private set { } //Length: 78
	}

	internal GroupCollection(Match match, Hashtable caps) { }

	internal GroupCollection() { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override void CopyTo(Group[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override Group get_Item(int groupnum) { }

	public Group get_Item(string groupname) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	private Group GetGroup(int groupnum) { }

	private Group GetGroupImpl(int groupnum) { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	private override IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

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

