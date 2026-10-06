namespace System.Net.NetworkInformation;

internal abstract class NetworkInterfaceFactory
{

	protected NetworkInterfaceFactory() { }

	public static NetworkInterfaceFactory Create() { }

	public abstract NetworkInterface[] GetAllNetworkInterfaces() { }

}

