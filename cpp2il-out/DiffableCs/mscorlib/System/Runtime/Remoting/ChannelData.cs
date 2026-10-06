namespace System.Runtime.Remoting;

internal class ChannelData
{
	internal string Ref; //Field offset: 0x10
	internal string Type; //Field offset: 0x18
	internal string Id; //Field offset: 0x20
	internal string DelayLoadAsClientChannel; //Field offset: 0x28
	private ArrayList _serverProviders; //Field offset: 0x30
	private ArrayList _clientProviders; //Field offset: 0x38
	private Hashtable _customProperties; //Field offset: 0x40

	public ArrayList ClientProviders
	{
		 get { } //Length: 105
	}

	public Hashtable CustomProperties
	{
		 get { } //Length: 105
	}

	internal ArrayList ServerProviders
	{
		internal get { } //Length: 105
	}

	public ChannelData() { }

	public void CopyFrom(ChannelData other) { }

	public ArrayList get_ClientProviders() { }

	public Hashtable get_CustomProperties() { }

	internal ArrayList get_ServerProviders() { }

}

