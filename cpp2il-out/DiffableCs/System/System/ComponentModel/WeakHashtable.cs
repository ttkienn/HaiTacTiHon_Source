namespace System.ComponentModel;

internal sealed class WeakHashtable : Hashtable
{
	private class WeakKeyComparer : IEqualityComparer
	{

		public WeakKeyComparer() { }

		private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

		private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	}

	private static IEqualityComparer _comparer; //Field offset: 0x0

	private static WeakHashtable() { }

	internal WeakHashtable() { }

	public virtual void Clear() { }

	public virtual void Remove(object key) { }

}

