namespace UnityEngine.UIElements.UIR;

internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
{
	public int useCount; //Field offset: 0x18
	public GradientRemap firstGradientRemap; //Field offset: 0x20
	public Alloc gradientSettingsAlloc; //Field offset: 0x28

	public VectorImageRenderInfo() { }

	public void Reset() { }

}

