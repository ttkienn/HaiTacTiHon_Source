namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Capture>))]
[DefaultMember("Item")]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection
{
	private sealed class Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator
	{
		private readonly CaptureCollection _collection; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override Capture Current
		{
			 get { } //Length: 133
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 133
		}

		internal Enumerator(CaptureCollection collection) { }

		public override Capture get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.IDisposable.Dispose() { }

	}

	private readonly Group _group; //Field offset: 0x10
	private readonly int _capcount; //Field offset: 0x18
	private Capture[] _captures; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override Capture Item
	{
		 get { } //Length: 8
	}

	public override object SyncRoot
	{
		 get { } //Length: 5
	}

	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item
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

	internal CaptureCollection() { }

	public override void CopyTo(Capture[] array, int arrayIndex) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	internal void ForceInitialized() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override Capture get_Item(int i) { }

	public override object get_SyncRoot() { }

	private Capture GetCapture(int i) { }

	public override IEnumerator GetEnumerator() { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	private override IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

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

