namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoSkeletonBone")]
[RequiredByNativeCode]
public struct SkeletonBone
{
	[NativeName("m_Name")]
	public string name; //Field offset: 0x0
	[NativeName("m_ParentName")]
	internal string parentName; //Field offset: 0x8
	[NativeName("m_Position")]
	public Vector3 position; //Field offset: 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; //Field offset: 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; //Field offset: 0x2C

}

