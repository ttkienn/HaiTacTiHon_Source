namespace System.Net.NetworkInformation;

internal class Win32NetworkInterface
{
	private static Win32_FIXED_INFO fixedInfo; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x58

	public static Win32_FIXED_INFO FixedInfo
	{
		 get { } //Length: 1711
	}

	[CompilerGenerated]
	internal static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(Byte* bytes) { }

	public static Win32_FIXED_INFO get_FixedInfo() { }

	private static int GetNetworkParams(IntPtr ptr, ref int size) { }

	private static int MultiByteToWideChar(uint CodePage, uint dwFlags, Byte* lpMultiByteStr, int cbMultiByte, Char* lpWideCharStr, int cchWideChar) { }

}

