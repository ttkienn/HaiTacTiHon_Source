namespace System.Net.NetworkInformation;

internal struct Win32_IP_ADDR_STRING
{
	public IntPtr Next; //Field offset: 0x0
	public string IpAddress; //Field offset: 0x8
	public string IpMask; //Field offset: 0x10
	public uint Context; //Field offset: 0x18

}

