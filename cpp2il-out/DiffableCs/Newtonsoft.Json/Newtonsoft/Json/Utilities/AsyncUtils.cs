namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class AsyncUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Action <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <FromCanceled>b__5_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__6
	{
		[Nullable(0)]
		public static readonly <>c__6<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<T> <>9__6_0; //Field offset: 0x0

		private static <>c__6`1() { }

		public <>c__6`1() { }

		[NullableContext(0)]
		internal T <FromCanceled>b__6_0() { }

	}

	public static readonly Task<Boolean> False; //Field offset: 0x0
	public static readonly Task<Boolean> True; //Field offset: 0x8
	internal static readonly Task CompletedTask; //Field offset: 0x10

	private static AsyncUtils() { }

	[Extension]
	[NullableContext(2)]
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Extension]
	[NullableContext(2)]
	public static Task<T> CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Extension]
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Extension]
	public static Task<T> FromCanceled(CancellationToken cancellationToken) { }

	[Extension]
	public static bool IsCompletedSuccessfully(Task task) { }

	[Extension]
	public static Task<Int32> ReadAsync(TextReader reader, Char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Extension]
	internal static Task<Boolean> ToAsync(bool value) { }

	[Extension]
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[Extension]
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[Extension]
	public static Task WriteAsync(TextWriter writer, Char[] value, int start, int count, CancellationToken cancellationToken) { }

}

