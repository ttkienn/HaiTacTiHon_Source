namespace System.Text;

internal static class EncodingHelper
{
	private static Encoding utf8EncodingWithoutMarkers; //Field offset: 0x0
	private static readonly object lockobj; //Field offset: 0x8
	private static Assembly i18nAssembly; //Field offset: 0x10
	private static bool i18nDisabled; //Field offset: 0x18

	internal static Encoding UTF8Unmarked
	{
		internal get { } //Length: 503
	}

	private static EncodingHelper() { }

	internal static Encoding get_UTF8Unmarked() { }

	internal static Encoding GetDefaultEncoding() { }

	internal static string InternalCodePage(ref int code_page) { }

	internal static object InvokeI18N(string name, Object[] args) { }

}

