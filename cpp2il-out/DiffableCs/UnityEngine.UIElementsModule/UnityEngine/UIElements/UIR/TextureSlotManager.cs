namespace UnityEngine.UIElements.UIR;

internal class TextureSlotManager
{
	internal static readonly int k_SlotCount; //Field offset: 0x0
	internal static readonly int k_SlotSize; //Field offset: 0x4
	internal static readonly Int32[] slotIds; //Field offset: 0x8
	internal static readonly int textureTableId; //Field offset: 0x10
	private TextureId[] m_Textures; //Field offset: 0x10
	private Int32[] m_Tickets; //Field offset: 0x18
	private int m_CurrentTicket; //Field offset: 0x20
	private int m_FirstUsedTicket; //Field offset: 0x24
	private Vector4[] m_GpuTextures; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <FreeSlots>k__BackingField; //Field offset: 0x30
	internal TextureRegistry textureRegistry; //Field offset: 0x38

	public private int FreeSlots
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static TextureSlotManager() { }

	public TextureSlotManager() { }

	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	public int FindOldestSlot() { }

	[CompilerGenerated]
	public int get_FreeSlots() { }

	public int IndexOf(TextureId id) { }

	public void MarkUsed(int slotIndex) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_FreeSlots(int value) { }

	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale) { }

	public void StartNewBatch() { }

}

