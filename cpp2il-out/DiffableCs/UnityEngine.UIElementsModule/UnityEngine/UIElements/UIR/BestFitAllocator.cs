namespace UnityEngine.UIElements.UIR;

internal class BestFitAllocator
{
	private class Block : LinkedPoolItem<Block>
	{
		public uint start; //Field offset: 0x18
		public uint end; //Field offset: 0x1C
		public Block prev; //Field offset: 0x20
		public Block next; //Field offset: 0x28
		public Block prevAvailable; //Field offset: 0x30
		public Block nextAvailable; //Field offset: 0x38
		public bool allocated; //Field offset: 0x40

		public uint size
		{
			 get { } //Length: 9
		}

		public Block() { }

		public uint get_size() { }

	}

	private class BlockPool : LinkedPool<Block>
	{

		public BlockPool() { }

		private static Block CreateBlock() { }

		private static void ResetBlock(Block block) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly uint <totalSize>k__BackingField; //Field offset: 0x10
	private Block m_FirstBlock; //Field offset: 0x18
	private Block m_FirstAvailableBlock; //Field offset: 0x20
	private BlockPool m_BlockPool; //Field offset: 0x28
	private uint m_HighWatermark; //Field offset: 0x30

	public uint highWatermark
	{
		 get { } //Length: 6
	}

	public uint totalSize
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	public BestFitAllocator(uint size) { }

	public Alloc Allocate(uint size) { }

	private Block BestFitFindAvailableBlock(uint size) { }

	private Block CoalesceBlockWithPrevious(Block block) { }

	public void Free(Alloc alloc) { }

	public uint get_highWatermark() { }

	[CompilerGenerated]
	public uint get_totalSize() { }

	private void SplitBlock(Block block, uint size) { }

}

