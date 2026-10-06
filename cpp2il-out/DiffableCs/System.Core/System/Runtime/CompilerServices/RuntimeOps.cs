namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public static class RuntimeOps
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

}

