namespace System.Linq;

internal struct Buffer
{
	internal TElement[] items; //Field offset: 0x0
	internal int count; //Field offset: 0x0

	internal Buffer`1(IEnumerable<TElement> source) { }

	internal TElement[] ToArray() { }

}

