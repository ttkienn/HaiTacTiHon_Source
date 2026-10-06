namespace System;

[ComVisible(True)]
public static class Buffer
{

	private static int _ByteLength(Array array) { }

	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	public static int ByteLength(Array array) { }

	internal static int IndexOfByte(Byte* src, byte value, int index, int count) { }

	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	internal static void InternalMemcpy(Byte* dest, Byte* src, int count) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal static void Memcpy(Byte* pDest, int destIndex, Byte[] src, int srcIndex, int len) { }

	internal static void Memcpy(Byte* dest, Byte* src, int len) { }

	private static void memcpy1(Byte* dest, Byte* src, int size) { }

	internal static void memcpy2(Byte* dest, Byte* src, int size) { }

	internal static void memcpy4(Byte* dest, Byte* src, int size) { }

	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	internal static void Memmove(ref T destination, ref T source, ulong elementCount) { }

	[CLSCompliant(False)]
	public static void MemoryCopy(Void* source, Void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	internal static void ZeroMemory(Byte* src, long len) { }

}

