namespace UnityEngine.UIElements;

internal struct CountingBloomFilter
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_Counters>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(byte, 16384)]
	private <m_Counters>e__FixedBuffer m_Counters; //Field offset: 0x0

	private void AdjustSlot(uint index, bool increment) { }

	public bool ContainsHash(uint hash) { }

	private uint Hash1(uint hash) { }

	private uint Hash2(uint hash) { }

	public void InsertHash(uint hash) { }

	private bool IsSlotEmpty(uint index) { }

	public void RemoveHash(uint hash) { }

}

