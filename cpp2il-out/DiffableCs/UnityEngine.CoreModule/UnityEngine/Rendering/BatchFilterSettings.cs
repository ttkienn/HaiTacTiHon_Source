namespace UnityEngine.Rendering;

public struct BatchFilterSettings
{
	public uint renderingLayerMask; //Field offset: 0x0
	public byte layer; //Field offset: 0x4
	private byte m_motionMode; //Field offset: 0x5
	private byte m_shadowMode; //Field offset: 0x6
	private byte m_receiveShadows; //Field offset: 0x7
	private byte m_staticShadowCaster; //Field offset: 0x8
	private byte m_allDepthSorted; //Field offset: 0x9

}

