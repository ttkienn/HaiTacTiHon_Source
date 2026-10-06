namespace System.Net;

public class IPHostEntry
{
	private string hostName; //Field offset: 0x10
	private String[] aliases; //Field offset: 0x18
	private IPAddress[] addressList; //Field offset: 0x20
	internal bool isTrustedHost; //Field offset: 0x28

	public IPAddress[] AddressList
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public String[] Aliases
	{
		 set { } //Length: 13
	}

	public string HostName
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public IPHostEntry() { }

	public IPAddress[] get_AddressList() { }

	public string get_HostName() { }

	public void set_AddressList(IPAddress[] value) { }

	public void set_Aliases(String[] value) { }

	public void set_HostName(string value) { }

}

