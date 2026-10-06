namespace System.Runtime.Remoting.Channels;

internal class AsyncRequest
{
	internal IMessageSink ReplySink; //Field offset: 0x10
	internal IMessage MsgRequest; //Field offset: 0x18

	public AsyncRequest(IMessage msgRequest, IMessageSink replySink) { }

}

