namespace UnityEngine.UIElements.UIR;

internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	public int origIndex; //Field offset: 0x18
	public int destIndex; //Field offset: 0x1C
	public RectInt location; //Field offset: 0x20
	public GradientRemap next; //Field offset: 0x30
	public TextureId atlas; //Field offset: 0x38

	public GradientRemap() { }

	public void Reset() { }

}

