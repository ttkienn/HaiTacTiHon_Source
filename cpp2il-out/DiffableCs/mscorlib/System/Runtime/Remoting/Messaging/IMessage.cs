namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public interface IMessage
{

	public IDictionary Properties
	{
		 get { } //Length: 0
	}

	public IDictionary get_Properties() { }

}

