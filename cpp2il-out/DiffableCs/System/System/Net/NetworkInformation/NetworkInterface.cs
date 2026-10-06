namespace System.Net.NetworkInformation;

public abstract class NetworkInterface
{

	protected NetworkInterface() { }

	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	public override PhysicalAddress GetPhysicalAddress() { }

}

