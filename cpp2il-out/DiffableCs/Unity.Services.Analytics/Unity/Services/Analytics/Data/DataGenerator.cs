namespace Unity.Services.Analytics.Data;

internal class DataGenerator : IDataGenerator
{
	public enum SessionEndState
	{
		PAUSED = 0,
		KILLEDINBACKGROUND = 1,
		KILLEDINFOREGROUND = 2,
		QUIT = 3,
	}

	private readonly IBuffer m_Buffer; //Field offset: 0x10
	private readonly ICommonData m_CommonData; //Field offset: 0x18
	private readonly IDeviceData m_DeviceData; //Field offset: 0x20

	public DataGenerator(IBuffer buffer, ICommonData staticData, IDeviceData deviceData) { }

	public override void ClientDevice(string callingMethodIdentifier) { }

	public override void GameEnded(string callingMethodIdentifier, SessionEndState quitState) { }

	public override void GameRunning(string callingMethodIdentifier) { }

	public override void GameStarted(string callingMethodIdentifier) { }

	public override void NewPlayer(string callingMethodIdentifier) { }

	public override void PushCommonParams(string callingMethodIdentifier) { }

	public override void PushEmptyEvent(string name) { }

	public override void PushEvent(string callingMethodIdentifier, Event e) { }

	public override void SdkStartup(string callingMethodIdentifier) { }

}

