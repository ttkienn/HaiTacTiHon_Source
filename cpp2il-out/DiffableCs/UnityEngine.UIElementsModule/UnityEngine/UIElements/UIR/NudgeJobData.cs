namespace UnityEngine.UIElements.UIR;

internal struct NudgeJobData
{
	public IntPtr src; //Field offset: 0x0
	public IntPtr dst; //Field offset: 0x8
	public int count; //Field offset: 0x10
	public IntPtr closingSrc; //Field offset: 0x18
	public IntPtr closingDst; //Field offset: 0x20
	public int closingCount; //Field offset: 0x28
	public Matrix4x4 transform; //Field offset: 0x2C
	public int vertsBeforeUVDisplacement; //Field offset: 0x6C
	public int vertsAfterUVDisplacement; //Field offset: 0x70

}

