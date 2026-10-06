namespace System.Reflection;

public sealed class MemberFilter : MulticastDelegate
{

	public MemberFilter(object object, IntPtr method) { }

	public override bool Invoke(MemberInfo m, object filterCriteria) { }

}

