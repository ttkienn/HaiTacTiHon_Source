namespace UnityEngine.UIElements;

public static class UQuery
{
	public class FirstQueryMatcher : SingleQueryMatcher
	{
		public static readonly FirstQueryMatcher Instance; //Field offset: 0x0

		private static FirstQueryMatcher() { }

		public FirstQueryMatcher() { }

		public virtual SingleQueryMatcher CreateNew() { }

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	public class IsOfType : IVisualPredicateWrapper
	{
		public static IsOfType<T> s_Instance; //Field offset: 0x0

		private static IsOfType`1() { }

		public IsOfType`1() { }

		public override bool Predicate(object e) { }

	}

	public interface IVisualPredicateWrapper
	{

		public bool Predicate(object e) { }

	}

	public abstract class SingleQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private VisualElement <match>k__BackingField; //Field offset: 0x18

		public VisualElement match
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		protected SingleQueryMatcher() { }

		public abstract SingleQueryMatcher CreateNew() { }

		[CompilerGenerated]
		public VisualElement get_match() { }

		public bool IsInUse() { }

		public virtual void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[CompilerGenerated]
		public void set_match(VisualElement value) { }

	}

	public abstract class UQueryMatcher : HierarchyTraversal
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<VisualElement, MatchResultInfo> <>9__5_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

		}

		internal List<RuleMatcher> m_Matchers; //Field offset: 0x10

		protected UQueryMatcher() { }

		private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		public override void Run(VisualElement root, List<RuleMatcher> matchers) { }

		public virtual void Traverse(VisualElement element) { }

		public virtual void TraverseRecursive(VisualElement element, int depth) { }

	}


}

