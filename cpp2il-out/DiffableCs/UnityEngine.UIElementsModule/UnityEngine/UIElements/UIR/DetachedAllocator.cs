namespace UnityEngine.UIElements.UIR;

internal class DetachedAllocator : IDisposable
{
	private TempAllocator<Vertex> m_VertsPool; //Field offset: 0x10
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x18
	private List<MeshWriteData> m_MeshWriteDataPool; //Field offset: 0x20
	private int m_MeshWriteDataCount; //Field offset: 0x28
	private bool m_Disposed; //Field offset: 0x2C

	public DetachedAllocator() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

}

