namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType::DoubleColon (2))]
internal static class BurstLike
{
	public static class SharedStatic
	{

		public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

	}

	[IsReadOnly]
	public struct SharedStatic
	{
		private readonly Void* _buffer; //Field offset: 0x0

		public T Data
		{
			 get { } //Length: 36
		}

		private SharedStatic`1(Void* buffer) { }

		public T get_Data() { }

		public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	}


}

