namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContributeClientContextSink
{

	public IMessageSink GetClientContextSink(IMessageSink nextSink) { }

}

