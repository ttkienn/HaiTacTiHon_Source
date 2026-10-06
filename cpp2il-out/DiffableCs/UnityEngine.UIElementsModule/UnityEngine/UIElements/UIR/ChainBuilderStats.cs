namespace UnityEngine.UIElements.UIR;

internal struct ChainBuilderStats
{
	public uint elementsAdded; //Field offset: 0x0
	public uint elementsRemoved; //Field offset: 0x4
	public uint recursiveClipUpdates; //Field offset: 0x8
	public uint recursiveClipUpdatesExpanded; //Field offset: 0xC
	public uint nonRecursiveClipUpdates; //Field offset: 0x10
	public uint recursiveTransformUpdates; //Field offset: 0x14
	public uint recursiveTransformUpdatesExpanded; //Field offset: 0x18
	public uint recursiveOpacityUpdates; //Field offset: 0x1C
	public uint recursiveOpacityUpdatesExpanded; //Field offset: 0x20
	public uint opacityIdUpdates; //Field offset: 0x24
	public uint colorUpdates; //Field offset: 0x28
	public uint colorUpdatesExpanded; //Field offset: 0x2C
	public uint recursiveVisualUpdates; //Field offset: 0x30
	public uint recursiveVisualUpdatesExpanded; //Field offset: 0x34
	public uint nonRecursiveVisualUpdates; //Field offset: 0x38
	public uint dirtyProcessed; //Field offset: 0x3C
	public uint nudgeTransformed; //Field offset: 0x40
	public uint boneTransformed; //Field offset: 0x44
	public uint skipTransformed; //Field offset: 0x48
	public uint visualUpdateTransformed; //Field offset: 0x4C
	public uint updatedMeshAllocations; //Field offset: 0x50
	public uint newMeshAllocations; //Field offset: 0x54
	public uint groupTransformElementsChanged; //Field offset: 0x58
	public uint immedateRenderersActive; //Field offset: 0x5C

}

