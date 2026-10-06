namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public interface IChannelSender : IChannel
{

	public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { }

}

