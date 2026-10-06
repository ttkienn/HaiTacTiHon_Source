//Type is in global namespace

public interface IMessageHandler
{

	public void onConnectionFail() { }

	public void onConnectOK() { }

	public void onDisconnected() { }

	public void onMessage(Message message) { }

}

