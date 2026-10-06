namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyVersion
{
	public ushort major; //Field offset: 0x0
	public ushort minor; //Field offset: 0x2
	public ushort build; //Field offset: 0x4
	public ushort revision; //Field offset: 0x6

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	public virtual string ToString() { }

}

