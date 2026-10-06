namespace System.Buffers;

public abstract class MemoryManager
{

	public abstract Span<T> GetSpan() { }

	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	protected private override bool TryGetArray(out ArraySegment<T>& segment) { }

}

