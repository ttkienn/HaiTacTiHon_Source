namespace System.Runtime.Remoting;

internal class ChannelInfo : IChannelInfo
{
	private Object[] channelData; //Field offset: 0x10

	public override Object[] ChannelData
	{
		 get { } //Length: 5
	}

	public ChannelInfo() { }

	public ChannelInfo(object remoteChannelData) { }

	public override Object[] get_ChannelData() { }

}

