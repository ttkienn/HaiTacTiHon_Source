namespace System.Linq.Expressions;

[Extension]
internal static class ArrayBuilderExtensions
{

	[Extension]
	public static ReadOnlyCollection<T> ToReadOnly(ArrayBuilder<T> builder) { }

}

