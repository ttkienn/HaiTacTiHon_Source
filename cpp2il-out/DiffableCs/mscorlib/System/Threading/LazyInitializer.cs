namespace System.Threading;

public static class LazyInitializer
{

	public static T EnsureInitialized(ref T target) { }

	public static T EnsureInitialized(ref T target, Func<T> valueFactory) { }

	public static T EnsureInitialized(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	public static T EnsureInitialized(ref T target, ref object syncLock, Func<T> valueFactory) { }

	private static T EnsureInitializedCore(ref T target) { }

	private static T EnsureInitializedCore(ref T target, Func<T> valueFactory) { }

	private static T EnsureInitializedCore(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	private static T EnsureInitializedCore(ref T target, ref object syncLock, Func<T> valueFactory) { }

	private static object EnsureLockInitialized(ref object syncLock) { }

}

