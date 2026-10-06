namespace System.Net.NetworkInformation;

internal struct Win32_FIXED_INFO
{
	public string HostName; //Field offset: 0x0
	public string DomainName; //Field offset: 0x8
	public IntPtr CurrentDnsServer; //Field offset: 0x10
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0x18
	public NetBiosNodeType NodeType; //Field offset: 0x38
	public string ScopeId; //Field offset: 0x40
	public uint EnableRouting; //Field offset: 0x48
	public uint EnableProxy; //Field offset: 0x4C
	public uint EnableDns; //Field offset: 0x50

}

