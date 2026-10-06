namespace UnityEngine.UIElements.UIR;

internal struct ConvertMeshJobData
{
	public IntPtr vertSrc; //Field offset: 0x0
	public IntPtr vertDst; //Field offset: 0x8
	public int vertCount; //Field offset: 0x10
	public Matrix4x4 transform; //Field offset: 0x14
	public int transformUVs; //Field offset: 0x54
	public Color32 xformClipPages; //Field offset: 0x58
	public Color32 ids; //Field offset: 0x5C
	public Color32 addFlags; //Field offset: 0x60
	public Color32 opacityPage; //Field offset: 0x64
	public Color32 textCoreSettingsPage; //Field offset: 0x68
	public int isText; //Field offset: 0x6C
	public float textureId; //Field offset: 0x70
	public IntPtr indexSrc; //Field offset: 0x78
	public IntPtr indexDst; //Field offset: 0x80
	public int indexCount; //Field offset: 0x88
	public int indexOffset; //Field offset: 0x8C
	public int flipIndices; //Field offset: 0x90

}

