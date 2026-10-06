namespace System.Buffers;

public abstract class ArrayPool
{
	[CompilerGenerated]
	private static readonly ArrayPool<T> <Shared>k__BackingField; //Field offset: 0x0

	public static ArrayPool<T> Shared
	{
		[CompilerGenerated]
		 get { } //Length: 153
	}

	private static ArrayPool`1() { }

	protected ArrayPool`1() { }

	[CompilerGenerated]
	public static ArrayPool<T> get_Shared() { }

	public abstract T[] Rent(int minimumLength) { }

	public abstract void Return(T[] array, bool clearArray = false) { }

}

