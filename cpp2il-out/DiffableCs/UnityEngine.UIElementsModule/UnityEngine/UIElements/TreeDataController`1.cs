namespace UnityEngine.UIElements;

internal sealed class TreeDataController
{
	[CompilerGenerated]
	private sealed class <GetAllItemIds>d__13 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private int <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<Int32> rootIds; //Field offset: 0x0
		public IEnumerable<Int32> <>3__rootIds; //Field offset: 0x0
		public TreeDataController<T> <>4__this; //Field offset: 0x0
		private IEnumerator<Int32> <currentIterator>5__1; //Field offset: 0x0
		private bool <hasNext>5__2; //Field offset: 0x0
		private int <currentItemId>5__3; //Field offset: 0x0

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 67
		}

		[DebuggerHidden]
		public <GetAllItemIds>d__13(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetItemIds>d__9 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private int <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TreeViewItemData`1<T>> items; //Field offset: 0x0
		public IEnumerable<TreeViewItemData`1<T>> <>3__items; //Field offset: 0x0
		private IEnumerator<TreeViewItemData`1<T>> <>s__1; //Field offset: 0x0
		private TreeViewItemData<T> <item>5__2; //Field offset: 0x0

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 67
		}

		[DebuggerHidden]
		public <GetItemIds>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private TreeData<T> m_TreeData; //Field offset: 0x0
	private Stack<IEnumerator`1<Int32>> m_IteratorStack; //Field offset: 0x0

	public TreeDataController`1() { }

	[IteratorStateMachine(typeof(<GetAllItemIds>d__13))]
	public IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	public IEnumerable<Int32> GetChildrenIds(int id) { }

	public T GetDataForId(int id) { }

	[IteratorStateMachine(typeof(<GetItemIds>d__9))]
	private static IEnumerable<Int32> GetItemIds(IEnumerable<TreeViewItemData`1<T>> items) { }

	public int GetParentId(int id) { }

	public bool HasChildren(int id) { }

	public bool IsChildOf(int childId, int id) { }

	public void Move(int id, int newParentId, int childIndex = -1) { }

	public void SetRootItems(IList<TreeViewItemData`1<T>> rootItems) { }

}

