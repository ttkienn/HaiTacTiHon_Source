namespace UnityEngine.Rendering;

public struct BatchDrawCommand
{
	public uint visibleOffset; //Field offset: 0x0
	public uint visibleCount; //Field offset: 0x4
	public BatchID batchID; //Field offset: 0x8
	public BatchMaterialID materialID; //Field offset: 0xC
	public BatchMeshID meshID; //Field offset: 0x10
	public ushort submeshIndex; //Field offset: 0x14
	public ushort splitVisibilityMask; //Field offset: 0x16
	public BatchDrawCommandFlags flags; //Field offset: 0x18
	public int sortingPosition; //Field offset: 0x1C

}

