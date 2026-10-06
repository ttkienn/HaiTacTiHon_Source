namespace System.Collections.Generic;

internal sealed class LowLevelListWithIList : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private LowLevelListWithIList<T> _list; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 123
		}

		internal Enumerator(LowLevelListWithIList<T> list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private bool MoveNextRare() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}


	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	public LowLevelListWithIList`1() { }

	public LowLevelListWithIList`1(int capacity) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

