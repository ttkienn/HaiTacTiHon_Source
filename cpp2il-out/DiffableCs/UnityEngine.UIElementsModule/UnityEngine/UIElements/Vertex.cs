namespace UnityEngine.UIElements;

public struct Vertex
{
	public static readonly float nearZ; //Field offset: 0x0
	public Vector3 position; //Field offset: 0x0
	public Color32 tint; //Field offset: 0xC
	public Vector2 uv; //Field offset: 0x10
	internal Color32 xformClipPages; //Field offset: 0x18
	internal Color32 ids; //Field offset: 0x1C
	internal Color32 flags; //Field offset: 0x20
	internal Color32 opacityColorPages; //Field offset: 0x24
	internal Color32 settingIndex; //Field offset: 0x28
	internal Vector4 circle; //Field offset: 0x2C
	internal float textureId; //Field offset: 0x3C

}

