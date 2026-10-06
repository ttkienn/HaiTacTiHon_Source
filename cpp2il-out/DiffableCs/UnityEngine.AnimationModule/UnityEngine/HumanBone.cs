namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoHumanBone")]
[RequiredByNativeCode]
public struct HumanBone
{
	private string m_BoneName; //Field offset: 0x0
	private string m_HumanName; //Field offset: 0x8
	[NativeName("m_Limit")]
	public HumanLimit limit; //Field offset: 0x10

}

