namespace System.Runtime.InteropServices;

public static class MemoryMarshal
{

	public static Span<Byte> AsBytes(Span<T> span) { }

	public static ReadOnlySpan<Byte> AsBytes(ReadOnlySpan<T> span) { }

	public static Memory<T> AsMemory(ReadOnlyMemory<T> memory) { }

	public static ReadOnlySpan<T> CreateReadOnlySpan(ref T reference, int length) { }

	internal static T GetNonNullPinnableReference(Span<T> span) { }

	internal static T GetNonNullPinnableReference(ReadOnlySpan<T> span) { }

	public static T GetReference(Span<T> span) { }

	public static T GetReference(ReadOnlySpan<T> span) { }

	public static bool TryGetArray(ReadOnlyMemory<T> memory, out ArraySegment<T>& segment) { }

}

