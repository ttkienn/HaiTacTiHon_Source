namespace Mono.Btls;

internal static class MonoBtlsError
{

	public static void ClearError() { }

	public static int GetError(out string file, out int line) { }

	public static int GetErrorReason(int error) { }

	public static string GetErrorString(int error) { }

	private static void mono_btls_error_clear_error() { }

	private static int mono_btls_error_get_error_line(out IntPtr file, out int line) { }

	private static void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	private static int mono_btls_error_get_reason(int error) { }

}

