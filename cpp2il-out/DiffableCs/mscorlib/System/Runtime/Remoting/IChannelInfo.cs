namespace System.Runtime.Remoting;

[ComVisible(True)]
public interface IChannelInfo
{

	public Object[] ChannelData
	{
		 get { } //Length: 0
	}

	public Object[] get_ChannelData() { }

}

