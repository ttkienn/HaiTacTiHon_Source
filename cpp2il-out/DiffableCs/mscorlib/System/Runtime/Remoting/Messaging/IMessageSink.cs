namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public interface IMessageSink
{

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

