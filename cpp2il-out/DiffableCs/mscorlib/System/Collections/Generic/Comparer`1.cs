namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer : IComparer, IComparer<T>
{
	private static Comparer<T> defaultComparer; //Field offset: 0x0

	public static Comparer<T> Default
	{
		 get { } //Length: 268
	}

	protected Comparer`1() { }

	public abstract int Compare(T x, T y) { }

	private static Comparer<T> CreateComparer() { }

	public static Comparer<T> get_Default() { }

	private override int System.Collections.IComparer.Compare(object x, object y) { }

}

