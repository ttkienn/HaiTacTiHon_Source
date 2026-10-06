namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", StaticAccessorType::DoubleColon (2))]
public static class UnsafeUtility
{
	private struct AlignOfHelper
	{
		public byte dummy; //Field offset: 0x0
		public T data; //Field offset: 0x0

	}


	public static Void* AddressOf(ref T output) { }

	public static int AlignOf() { }

	public static T As(ref U from) { }

	public static T AsRef(Void* ptr) { }

	public static bool EnumEquals(T lhs, T rhs) { }

	public static int EnumToInt(T enumValue) { }

	[ThreadSafe(ThrowsException = True)]
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	[ThreadSafe(ThrowsException = True)]
	public static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	public static void MemClear(Void* destination, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemCpy(Void* destination, Void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemSet(Void* destination, byte value, long size) { }

	public static T ReadArrayElement(Void* source, int index) { }

	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	public static int SizeOf() { }

	public static void WriteArrayElement(Void* destination, int index, T value) { }

	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

}

