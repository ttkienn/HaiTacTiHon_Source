namespace System;

[Extension]
internal static class FixedBufferExtensions
{

	[Extension]
	internal static bool FixedBufferEqualsString(ReadOnlySpan<Char> span, string value) { }

	[Extension]
	internal static int GetFixedBufferStringLength(ReadOnlySpan<Char> span) { }

	[Extension]
	internal static string GetStringFromFixedBuffer(ReadOnlySpan<Char> span) { }

}

