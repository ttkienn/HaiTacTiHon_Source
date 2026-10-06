namespace System.Runtime.CompilerServices;

internal static class AsyncTaskCache
{
	internal static readonly Task<Boolean> TrueTask; //Field offset: 0x0
	internal static readonly Task<Boolean> FalseTask; //Field offset: 0x8
	internal static readonly Task<Int32>[] Int32Tasks; //Field offset: 0x10

	private static AsyncTaskCache() { }

	internal static Task<TResult> CreateCacheableTask(TResult result) { }

	private static Task<Int32>[] CreateInt32Tasks() { }

}

