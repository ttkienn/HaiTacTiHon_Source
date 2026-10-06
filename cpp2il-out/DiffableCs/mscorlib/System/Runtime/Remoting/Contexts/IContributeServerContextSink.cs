namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContributeServerContextSink
{

	public IMessageSink GetServerContextSink(IMessageSink nextSink) { }

}

