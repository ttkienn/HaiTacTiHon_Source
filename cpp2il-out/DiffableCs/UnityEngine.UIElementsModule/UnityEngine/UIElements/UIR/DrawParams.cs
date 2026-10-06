namespace UnityEngine.UIElements.UIR;

internal class DrawParams
{
	internal static readonly Rect k_UnlimitedRect; //Field offset: 0x0
	internal static readonly Rect k_FullNormalizedRect; //Field offset: 0x10
	internal readonly Stack<Matrix4x4> view; //Field offset: 0x10
	internal readonly Stack<Rect> scissor; //Field offset: 0x18
	internal readonly List<RenderTexture> renderTexture; //Field offset: 0x20
	internal readonly List<Material> defaultMaterial; //Field offset: 0x28

	private static DrawParams() { }

	public DrawParams() { }

	public void Reset() { }

}

