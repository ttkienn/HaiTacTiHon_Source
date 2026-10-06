namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public static class CallSiteOps
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void AddRule(CallSite<T> site, T rule) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T Bind(CallSiteBinder binder, CallSite<T> site, Object[] args) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static CallSite<T> CreateMatchmaker(CallSite<T> site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetCachedRules(RuleCache<T> cache) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static RuleCache<T> GetRuleCache(CallSite<T> site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetRules(CallSite<T> site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void MoveRule(RuleCache<T> cache, T rule, int i) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void UpdateRules(CallSite<T> this, int matched) { }

}

