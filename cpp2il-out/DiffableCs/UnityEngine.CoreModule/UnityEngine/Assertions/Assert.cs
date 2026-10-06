namespace UnityEngine.Assertions;

[DebuggerStepThrough]
public static class Assert
{
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	public static bool raiseExceptions; //Field offset: 0x0

	private static Assert() { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(T expected, T actual) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(T expected, T actual, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(T expected, T actual, string message, IEqualityComparer<T> comparer) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(object expected, object actual, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(int expected, int actual) { }

	private static void Fail(string message, string userMessage) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsFalse(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNotNull(T value) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNotNull(T value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNotNull(object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNull(T value) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNull(T value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNull(object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsTrue(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void IsTrue(bool condition, string message) { }

}

