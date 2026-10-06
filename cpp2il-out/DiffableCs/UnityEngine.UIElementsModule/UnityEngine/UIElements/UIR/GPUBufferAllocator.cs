namespace UnityEngine.UIElements.UIR;

internal class GPUBufferAllocator
{
	private BestFitAllocator m_Low; //Field offset: 0x10
	private BestFitAllocator m_High; //Field offset: 0x18

	public bool isEmpty
	{
		 get { } //Length: 53
	}

	public GPUBufferAllocator(uint maxSize) { }

	public Alloc Allocate(uint size, bool shortLived) { }

	public void Free(Alloc alloc) { }

	public bool get_isEmpty() { }

	private bool HighLowCollide() { }

}

