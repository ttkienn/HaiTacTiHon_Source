namespace System.Net.NetworkInformation;

internal struct Win32_FIXED_INFO_Marshal
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <DomainName>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <HostName>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <ScopeId>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(byte, 132)]
	public <HostName>e__FixedBuffer HostName; //Field offset: 0x0
	[FixedBuffer(typeof(byte, 132)]
	public <DomainName>e__FixedBuffer DomainName; //Field offset: 0x84
	public IntPtr CurrentDnsServer; //Field offset: 0x108
	public Win32_IP_ADDR_STRING DnsServerList; //Field offset: 0x110
	public NetBiosNodeType NodeType; //Field offset: 0x130
	[FixedBuffer(typeof(byte, 260)]
	public <ScopeId>e__FixedBuffer ScopeId; //Field offset: 0x134
	public uint EnableRouting; //Field offset: 0x238
	public uint EnableProxy; //Field offset: 0x23C
	public uint EnableDns; //Field offset: 0x240

}

