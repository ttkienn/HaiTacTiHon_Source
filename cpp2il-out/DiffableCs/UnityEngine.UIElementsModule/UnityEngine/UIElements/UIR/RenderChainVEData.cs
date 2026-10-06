namespace UnityEngine.UIElements.UIR;

internal struct RenderChainVEData
{
	internal VisualElement prev; //Field offset: 0x0
	internal VisualElement next; //Field offset: 0x8
	internal VisualElement groupTransformAncestor; //Field offset: 0x10
	internal VisualElement boneTransformAncestor; //Field offset: 0x18
	internal VisualElement prevDirty; //Field offset: 0x20
	internal VisualElement nextDirty; //Field offset: 0x28
	internal RenderDataFlags flags; //Field offset: 0x30
	internal int hierarchyDepth; //Field offset: 0x34
	internal RenderDataDirtyTypes dirtiedValues; //Field offset: 0x38
	internal uint dirtyID; //Field offset: 0x3C
	internal RenderChainCommand firstCommand; //Field offset: 0x40
	internal RenderChainCommand lastCommand; //Field offset: 0x48
	internal RenderChainCommand firstClosingCommand; //Field offset: 0x50
	internal RenderChainCommand lastClosingCommand; //Field offset: 0x58
	internal bool isInChain; //Field offset: 0x60
	internal bool isHierarchyHidden; //Field offset: 0x61
	internal bool localFlipsWinding; //Field offset: 0x62
	internal bool localTransformScaleZero; //Field offset: 0x63
	internal bool worldFlipsWinding; //Field offset: 0x64
	public bool worldTransformScaleZero; //Field offset: 0x65
	internal ClipMethod clipMethod; //Field offset: 0x68
	internal int childrenStencilRef; //Field offset: 0x6C
	internal int childrenMaskDepth; //Field offset: 0x70
	internal bool disableNudging; //Field offset: 0x74
	internal MeshHandle data; //Field offset: 0x78
	internal MeshHandle closingData; //Field offset: 0x80
	internal Matrix4x4 verticesSpace; //Field offset: 0x88
	internal int displacementUVStart; //Field offset: 0xC8
	internal int displacementUVEnd; //Field offset: 0xCC
	internal BMPAlloc transformID; //Field offset: 0xD0
	internal BMPAlloc clipRectID; //Field offset: 0xD8
	internal BMPAlloc opacityID; //Field offset: 0xE0
	internal BMPAlloc textCoreSettingsID; //Field offset: 0xE8
	internal BMPAlloc colorID; //Field offset: 0xF0
	internal BMPAlloc backgroundColorID; //Field offset: 0xF8
	internal BMPAlloc borderLeftColorID; //Field offset: 0x100
	internal BMPAlloc borderTopColorID; //Field offset: 0x108
	internal BMPAlloc borderRightColorID; //Field offset: 0x110
	internal BMPAlloc borderBottomColorID; //Field offset: 0x118
	internal BMPAlloc tintColorID; //Field offset: 0x120
	internal float compositeOpacity; //Field offset: 0x128
	internal Color backgroundColor; //Field offset: 0x12C
	internal BasicNode<TextureEntry> textures; //Field offset: 0x140

	public bool isIgnoringDynamicColorHint
	{
		 get { } //Length: 7
	}

	internal RenderChainCommand lastClosingOrLastCommand
	{
		internal get { } //Length: 14
	}

	internal static bool AllocatesID(BMPAlloc alloc) { }

	public bool get_isIgnoringDynamicColorHint() { }

	internal RenderChainCommand get_lastClosingOrLastCommand() { }

	internal static bool InheritsID(BMPAlloc alloc) { }

}

