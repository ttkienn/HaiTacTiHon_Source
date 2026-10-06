namespace System.Net.NetworkInformation;

public abstract class IPGlobalProperties
{

	public abstract string DomainName
	{
		 get { } //Length: 0
	}

	protected IPGlobalProperties() { }

	public abstract string get_DomainName() { }

	public static IPGlobalProperties GetIPGlobalProperties() { }

	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

}

