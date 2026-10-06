namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContributeEnvoySink
{

	public IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

