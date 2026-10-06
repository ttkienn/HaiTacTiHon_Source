namespace UnityEngine;

[NativeClass("ContactFilter", "struct ContactFilter;")]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct ContactFilter2D
{
	[NativeName("m_UseTriggers")]
	public bool useTriggers; //Field offset: 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; //Field offset: 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; //Field offset: 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; //Field offset: 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; //Field offset: 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; //Field offset: 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; //Field offset: 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; //Field offset: 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; //Field offset: 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; //Field offset: 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; //Field offset: 0x18

	private void CheckConsistency() { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	public void SetLayerMask(LayerMask layerMask) { }

}

