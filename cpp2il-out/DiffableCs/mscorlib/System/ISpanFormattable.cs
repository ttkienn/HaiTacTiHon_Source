namespace System;

internal interface ISpanFormattable
{

	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

}

