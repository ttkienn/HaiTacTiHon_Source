namespace UnityEngine.Rendering;

public struct BatchCullingOutputDrawCommands
{
	public BatchDrawCommand* drawCommands; //Field offset: 0x0
	public Int32* visibleInstances; //Field offset: 0x8
	public BatchDrawRange* drawRanges; //Field offset: 0x10
	public Single* instanceSortingPositions; //Field offset: 0x18
	public Int32* drawCommandPickingInstanceIDs; //Field offset: 0x20
	public int drawCommandCount; //Field offset: 0x28
	public int visibleInstanceCount; //Field offset: 0x2C
	public int drawRangeCount; //Field offset: 0x30
	public int instanceSortingPositionFloatCount; //Field offset: 0x34

}

