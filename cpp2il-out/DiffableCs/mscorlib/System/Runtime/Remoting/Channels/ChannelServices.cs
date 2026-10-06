namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public sealed class ChannelServices
{
	private static ArrayList registeredChannels; //Field offset: 0x0
	private static ArrayList delayedClientChannels; //Field offset: 0x8
	private static CrossContextChannel _crossContextSink; //Field offset: 0x10
	internal static string CrossContextUrl; //Field offset: 0x18
	private static IList oldStartModeTypes; //Field offset: 0x20

	internal static CrossContextChannel CrossContextChannel
	{
		internal get { } //Length: 79
	}

	private static ChannelServices() { }

	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Object[] channelDataArray, out string objectUri) { }

	private static object CreateProvider(ProviderData prov) { }

	internal static CrossContextChannel get_CrossContextChannel() { }

	internal static Object[] GetCurrentChannelInfo() { }

	private static bool IsLocalCall(IMessage callMsg) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	public static void RegisterChannel(IChannel chnl) { }

	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	internal static void RegisterChannelConfig(ChannelData channel) { }

	public static IMessage SyncDispatchMessage(IMessage msg) { }

}

