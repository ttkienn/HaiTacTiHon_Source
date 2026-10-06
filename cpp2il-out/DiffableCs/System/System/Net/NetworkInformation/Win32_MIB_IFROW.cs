namespace System.Net.NetworkInformation;

internal struct Win32_MIB_IFROW
{
	public Char[] Name; //Field offset: 0x0
	public int Index; //Field offset: 0x8
	public NetworkInterfaceType Type; //Field offset: 0xC
	public int Mtu; //Field offset: 0x10
	public uint Speed; //Field offset: 0x14
	public int PhysAddrLen; //Field offset: 0x18
	public Byte[] PhysAddr; //Field offset: 0x20
	public uint AdminStatus; //Field offset: 0x28
	public uint OperStatus; //Field offset: 0x2C
	public uint LastChange; //Field offset: 0x30
	public int InOctets; //Field offset: 0x34
	public int InUcastPkts; //Field offset: 0x38
	public int InNUcastPkts; //Field offset: 0x3C
	public int InDiscards; //Field offset: 0x40
	public int InErrors; //Field offset: 0x44
	public int InUnknownProtos; //Field offset: 0x48
	public int OutOctets; //Field offset: 0x4C
	public int OutUcastPkts; //Field offset: 0x50
	public int OutNUcastPkts; //Field offset: 0x54
	public int OutDiscards; //Field offset: 0x58
	public int OutErrors; //Field offset: 0x5C
	public int OutQLen; //Field offset: 0x60
	public int DescrLen; //Field offset: 0x64
	public Byte[] Descr; //Field offset: 0x68

}

