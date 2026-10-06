namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	[RequiredByNativeCode]
	public Gradient() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Gradient other) { }

	protected virtual void Finalize() { }

	public virtual int GetHashCode() { }

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	private bool Internal_Equals(IntPtr other) { }

}

