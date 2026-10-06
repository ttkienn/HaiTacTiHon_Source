namespace Unity.Collections;

[NativeContainer]
internal struct NativeArrayDispose
{
	[NativeDisableUnsafePtrRestriction]
	internal Void* m_Buffer; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x8

	public void Dispose() { }

}

