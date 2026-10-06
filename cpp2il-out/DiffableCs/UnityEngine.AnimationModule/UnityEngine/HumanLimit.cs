namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeType(CodegenOptions::Custom (1), "MonoHumanLimit")]
public struct HumanLimit
{
	private Vector3 m_Min; //Field offset: 0x0
	private Vector3 m_Max; //Field offset: 0xC
	private Vector3 m_Center; //Field offset: 0x18
	private float m_AxisLength; //Field offset: 0x24
	private int m_UseDefaultValues; //Field offset: 0x28

}

