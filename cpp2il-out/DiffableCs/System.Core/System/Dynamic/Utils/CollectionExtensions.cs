namespace System.Dynamic.Utils;

[Extension]
internal static class CollectionExtensions
{

	[Extension]
	public static TrueReadOnlyCollection<T> AddFirst(ReadOnlyCollection<T> list, T item) { }

	[Extension]
	public static T[] AddLast(T[] array, T item) { }

	[Extension]
	public static T[] RemoveFirst(T[] array) { }

	[Extension]
	public static T[] RemoveLast(T[] array) { }

	[Extension]
	public static ReadOnlyCollection<T> ToReadOnly(IEnumerable<T> enumerable) { }

}

