namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	private static object s_lock; //Field offset: 0x0

	public override object ChannelData
	{
		 get { } //Length: 89
	}

	public override string ChannelName
	{
		 get { } //Length: 44
	}

	public override int ChannelPriority
	{
		 get { } //Length: 6
	}

	private static CrossAppDomainChannel() { }

	public CrossAppDomainChannel() { }

	public override IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	public override object get_ChannelData() { }

	public override string get_ChannelName() { }

	public override int get_ChannelPriority() { }

	internal static void RegisterCrossAppDomainChannel() { }

	public override void StartListening(object data) { }

}

