namespace System.Net.NetworkInformation;

internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
{
	private readonly Win32_IP_ADAPTER_ADDRESSES addr; //Field offset: 0x10
	private readonly Win32_MIB_IFROW mib4; //Field offset: 0x118
	private readonly Win32_MIB_IFROW mib6; //Field offset: 0x188

	public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) { }

}

