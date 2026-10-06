namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute
{

	public FreeFunctionAttribute() { }

	public FreeFunctionAttribute(string name) { }

	public FreeFunctionAttribute(string name, bool isThreadSafe) { }

}

