namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal static class BufferUtils
{

	public static Char[] EnsureBufferSize(IArrayPool<Char> bufferPool, int size, Char[] buffer) { }

	[NullableContext(1)]
	public static Char[] RentBuffer(IArrayPool<Char> bufferPool, int minSize) { }

	public static void ReturnBuffer(IArrayPool<Char> bufferPool, Char[] buffer) { }

}

