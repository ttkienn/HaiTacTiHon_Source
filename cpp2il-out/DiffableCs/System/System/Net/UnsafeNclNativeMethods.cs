namespace System.Net;

internal static class UnsafeNclNativeMethods
{
	public static class HttpApi
	{
		public static class HTTP_REQUEST_HEADER_ID
		{
			private static String[] m_Strings; //Field offset: 0x0

			private static HTTP_REQUEST_HEADER_ID() { }

			internal static string ToString(int position) { }

		}

		private static String[] m_Strings; //Field offset: 0x0

		private static HttpApi() { }

	}

	public static class SecureStringHelper
	{

		internal static SecureString CreateSecureString(string plainString) { }

		internal static string CreateString(SecureString secureString) { }

	}


}

