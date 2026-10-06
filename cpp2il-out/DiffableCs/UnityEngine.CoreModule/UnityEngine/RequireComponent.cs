namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[RequiredByNativeCode]
public sealed class RequireComponent : Attribute
{
	public Type m_Type0; //Field offset: 0x10
	public Type m_Type1; //Field offset: 0x18
	public Type m_Type2; //Field offset: 0x20

	public RequireComponent(Type requiredComponent) { }

}

