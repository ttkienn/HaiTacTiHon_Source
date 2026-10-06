//Type is in global namespace

public class GlobalMessageHandler : Cmd_Message, IMessageHandler
{
	public static GlobalMessageHandler me; //Field offset: 0x0
	public GlobalLogicHandler globalLogicHandler; //Field offset: 0x20
	public IMiniGameMsgHandler miniGameMessageHandler; //Field offset: 0x28

	public GlobalMessageHandler() { }

	public static GlobalMessageHandler gI() { }

	public override void onConnectionFail() { }

	public override void onConnectOK() { }

	public override void onDisconnected() { }

	public override void onMessage(Message msg) { }

	private void printCmd(sbyte cmd, Int32[] list) { }

	public void setGameLogicHandler(GlobalLogicHandler gI) { }

}

