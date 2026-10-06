namespace System.Net.NetworkInformation;

internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
{
	private Win32_MIB_IFROW info; //Field offset: 0x10

	public Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info) { }

}

