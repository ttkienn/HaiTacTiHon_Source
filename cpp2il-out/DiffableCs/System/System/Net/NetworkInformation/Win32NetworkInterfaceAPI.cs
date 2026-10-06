namespace System.Net.NetworkInformation;

internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
{

	public Win32NetworkInterfaceAPI() { }

	private static int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size) { }

	private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }

	public virtual NetworkInterface[] GetAllNetworkInterfaces() { }

}

