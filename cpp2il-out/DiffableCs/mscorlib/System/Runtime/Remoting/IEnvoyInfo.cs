namespace System.Runtime.Remoting;

[ComVisible(True)]
public interface IEnvoyInfo
{

	public IMessageSink EnvoySinks
	{
		 get { } //Length: 0
	}

	public IMessageSink get_EnvoySinks() { }

}

