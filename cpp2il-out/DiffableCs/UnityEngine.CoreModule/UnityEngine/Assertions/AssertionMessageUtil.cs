namespace UnityEngine.Assertions;

internal class AssertionMessageUtil
{

	public static string BooleanFailureMessage(bool expected) { }

	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	public static string GetMessage(string failureMessage) { }

	public static string GetMessage(string failureMessage, string expected) { }

	public static string NullFailureMessage(object value, bool expectNull) { }

}

