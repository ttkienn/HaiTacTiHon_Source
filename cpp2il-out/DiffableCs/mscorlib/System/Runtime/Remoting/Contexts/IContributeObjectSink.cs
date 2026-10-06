namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContributeObjectSink
{

	public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

