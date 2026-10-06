namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute
{

	public ThreadSafeAttribute() { }

}

