namespace UnityEngine.UIElements;

public struct UQueryState : IEnumerable<T>, IEnumerable, IEquatable<UQueryState`1<T>>
{
	private class ActionQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Action<T> <callBack>k__BackingField; //Field offset: 0x0

		internal Action<T> callBack
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		public ActionQueryMatcher() { }

		[CompilerGenerated]
		internal Action<T> get_callBack() { }

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private List<VisualElement> iterationList; //Field offset: 0x0
		private int currentIndex; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 185
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 54
		}

		internal Enumerator(UQueryState<T> queryState) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private class ListQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private List<TElement> <matches>k__BackingField; //Field offset: 0x0

		public List<TElement> matches
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public ListQueryMatcher`1() { }

		[CompilerGenerated]
		public List<TElement> get_matches() { }

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_matches(List<TElement> value) { }

	}

	private static ActionQueryMatcher<T> s_Action; //Field offset: 0x0
	private static readonly ListQueryMatcher<T, T> s_List; //Field offset: 0x0
	private static readonly ListQueryMatcher<T, VisualElement> s_EnumerationList; //Field offset: 0x0
	private readonly VisualElement m_Element; //Field offset: 0x0
	internal readonly List<RuleMatcher> m_Matchers; //Field offset: 0x0

	private static UQueryState`1() { }

	internal UQueryState`1(VisualElement element, List<RuleMatcher> matchers) { }

	public override bool Equals(UQueryState<T> other) { }

	public virtual bool Equals(object obj) { }

	public T First() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public UQueryState<T> RebuildOn(VisualElement element) { }

	private T Single(SingleQueryMatcher matcher) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

