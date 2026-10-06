namespace System.Net.NetworkInformation;

internal static class SystemNetworkInterface
{
	private static readonly NetworkInterfaceFactory nif; //Field offset: 0x0

	private static SystemNetworkInterface() { }

	public static NetworkInterface[] GetNetworkInterfaces() { }

}

