namespace System.Net;

public class IPAddress
{
	private sealed class ReadOnlyIPAddress : IPAddress
	{

		public ReadOnlyIPAddress(long newAddress) { }

	}

	public static readonly IPAddress Any; //Field offset: 0x0
	internal const long LoopbackMask = 255; //Field offset: 0x0
	internal const int NumberOfLabels = 8; //Field offset: 0x0
	public static readonly IPAddress Loopback; //Field offset: 0x8
	public static readonly IPAddress Broadcast; //Field offset: 0x10
	public static readonly IPAddress None; //Field offset: 0x18
	public static readonly IPAddress IPv6Any; //Field offset: 0x20
	public static readonly IPAddress IPv6Loopback; //Field offset: 0x28
	public static readonly IPAddress IPv6None; //Field offset: 0x30
	private uint _addressOrScopeId; //Field offset: 0x10
	private readonly UInt16[] _numbers; //Field offset: 0x18
	private string _toString; //Field offset: 0x20
	private int _hashCode; //Field offset: 0x28

	public AddressFamily AddressFamily
	{
		 get { } //Length: 19
	}

	private bool IsIPv4
	{
		private get { } //Length: 9
	}

	private bool IsIPv6
	{
		private get { } //Length: 9
	}

	private uint PrivateAddress
	{
		private get { } //Length: 191
		private set { } //Length: 55
	}

	private uint PrivateScopeId
	{
		private get { } //Length: 191
		private set { } //Length: 55
	}

	public long ScopeId
	{
		 get { } //Length: 91
	}

	private static IPAddress() { }

	private IPAddress(UInt16[] numbers, uint scopeid) { }

	internal IPAddress(UInt16* numbers, int numbersLength, uint scopeid) { }

	public IPAddress(long newAddress) { }

	public IPAddress(Byte[] address, long scopeid) { }

	public IPAddress(ReadOnlySpan<Byte> address, long scopeid) { }

	public virtual bool Equals(object comparand) { }

	internal bool Equals(object comparandObj, bool compareScopeId) { }

	public AddressFamily get_AddressFamily() { }

	private bool get_IsIPv4() { }

	private bool get_IsIPv6() { }

	private uint get_PrivateAddress() { }

	private uint get_PrivateScopeId() { }

	public long get_ScopeId() { }

	public Byte[] GetAddressBytes() { }

	public virtual int GetHashCode() { }

	public static bool IsLoopback(IPAddress address) { }

	public IPAddress MapToIPv6() { }

	public static IPAddress Parse(string ipString) { }

	private void set_PrivateAddress(uint value) { }

	private void set_PrivateScopeId(uint value) { }

	private static Byte[] ThrowAddressNullException() { }

	public virtual string ToString() { }

	public static bool TryParse(string ipString, out IPAddress address) { }

	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten) { }

	private void WriteIPv4Bytes(Span<Byte> destination) { }

	private void WriteIPv6Bytes(Span<Byte> destination) { }

}

