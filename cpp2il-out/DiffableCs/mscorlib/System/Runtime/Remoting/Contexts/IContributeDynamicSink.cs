namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContributeDynamicSink
{

	public IDynamicMessageSink GetDynamicSink() { }

}

