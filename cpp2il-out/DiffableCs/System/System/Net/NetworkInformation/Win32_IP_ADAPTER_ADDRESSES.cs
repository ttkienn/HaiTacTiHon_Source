namespace System.Net.NetworkInformation;

internal struct Win32_IP_ADAPTER_ADDRESSES
{
	public AlignmentUnion Alignment; //Field offset: 0x0
	public IntPtr Next; //Field offset: 0x8
	public string AdapterName; //Field offset: 0x10
	public IntPtr FirstUnicastAddress; //Field offset: 0x18
	public IntPtr FirstAnycastAddress; //Field offset: 0x20
	public IntPtr FirstMulticastAddress; //Field offset: 0x28
	public IntPtr FirstDnsServerAddress; //Field offset: 0x30
	public string DnsSuffix; //Field offset: 0x38
	public string Description; //Field offset: 0x40
	public string FriendlyName; //Field offset: 0x48
	public Byte[] PhysicalAddress; //Field offset: 0x50
	public uint PhysicalAddressLength; //Field offset: 0x58
	public uint Flags; //Field offset: 0x5C
	public uint Mtu; //Field offset: 0x60
	public NetworkInterfaceType IfType; //Field offset: 0x64
	public OperationalStatus OperStatus; //Field offset: 0x68
	public int Ipv6IfIndex; //Field offset: 0x6C
	public UInt32[] ZoneIndices; //Field offset: 0x70
	public IntPtr FirstPrefix; //Field offset: 0x78
	public ulong TransmitLinkSpeed; //Field offset: 0x80
	public ulong ReceiveLinkSpeed; //Field offset: 0x88
	public IntPtr FirstWinsServerAddress; //Field offset: 0x90
	public IntPtr FirstGatewayAddress; //Field offset: 0x98
	public uint Ipv4Metric; //Field offset: 0xA0
	public uint Ipv6Metric; //Field offset: 0xA4
	public ulong Luid; //Field offset: 0xA8
	public Win32_SOCKET_ADDRESS Dhcpv4Server; //Field offset: 0xB0
	public uint CompartmentId; //Field offset: 0xC0
	public ulong NetworkGuid; //Field offset: 0xC8
	public int ConnectionType; //Field offset: 0xD0
	public int TunnelType; //Field offset: 0xD4
	public Win32_SOCKET_ADDRESS Dhcpv6Server; //Field offset: 0xD8
	public Byte[] Dhcpv6ClientDuid; //Field offset: 0xE8
	public ulong Dhcpv6ClientDuidLength; //Field offset: 0xF0
	public ulong Dhcpv6Iaid; //Field offset: 0xF8
	public IntPtr FirstDnsSuffix; //Field offset: 0x100

}

