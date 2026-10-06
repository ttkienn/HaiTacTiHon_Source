namespace System.Net;

internal static class NclUtilities
{
	private static IPAddress[] _LocalAddresses; //Field offset: 0x0
	private static object _LocalAddressesLock; //Field offset: 0x8
	internal static string _LocalDomainName; //Field offset: 0x10

	internal static IPAddress[] LocalAddresses
	{
		internal get { } //Length: 1274
	}

	private static object LocalAddressesLock
	{
		private get { } //Length: 155
	}

	internal static IPAddress[] get_LocalAddresses() { }

	private static object get_LocalAddressesLock() { }

	private static IPHostEntry GetLocalHost() { }

	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	internal static bool IsFatal(Exception exception) { }

}

