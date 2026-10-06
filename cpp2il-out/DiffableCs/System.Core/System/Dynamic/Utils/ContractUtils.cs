namespace System.Dynamic.Utils;

internal static class ContractUtils
{

	[ExcludeFromCodeCoverage]
	public static Exception Unreachable
	{
		 get { } //Length: 88
	}

	public static Exception get_Unreachable() { }

	private static string GetParamName(string paramName, int index) { }

	public static void Requires(bool precondition, string paramName) { }

	public static void RequiresArrayRange(IList<T> array, int offset, int count, string offsetName, string countName) { }

	public static void RequiresNotNull(object value, string paramName) { }

	public static void RequiresNotNull(object value, string paramName, int index) { }

	public static void RequiresNotNullItems(IList<T> array, string arrayName) { }

}

