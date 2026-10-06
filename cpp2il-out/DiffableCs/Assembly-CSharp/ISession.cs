//Type is in global namespace

public interface ISession
{

	public void close() { }

	public void connect(string host, int port) { }

	public bool isConnected() { }

	public void sendMessage(Message message) { }

	public void setHandler(IMessageHandler messageHandler) { }

}

