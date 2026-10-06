namespace UnityEngine.Networking.PlayerConnection;

public class PlayerConnection : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Guid messageId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <Register>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Guid messageId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <Unregister>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public bool msgReceived; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

	}

	internal static IPlayerEditorConnectionNative connectionNative; //Field offset: 0x0
	private static PlayerConnection s_Instance; //Field offset: 0x8
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; //Field offset: 0x18
	[SerializeField]
	private List<Int32> m_connectedPlayers; //Field offset: 0x20
	private bool m_IsInitilized; //Field offset: 0x28

	public static PlayerConnection instance
	{
		 get { } //Length: 399
	}

	public bool isConnected
	{
		 get { } //Length: 156
	}

	public PlayerConnection() { }

	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	[RequiredByNativeCode]
	private static void ConnectedCallbackInternal(int playerId) { }

	private static PlayerConnection CreateInstance() { }

	public override void DisconnectAll() { }

	[RequiredByNativeCode]
	private static void DisconnectedCallback(int playerId) { }

	public static PlayerConnection get_instance() { }

	public bool get_isConnected() { }

	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	[RequiredByNativeCode]
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	public void OnEnable() { }

	public override void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public override void RegisterConnection(UnityAction<Int32> callback) { }

	public override void RegisterDisconnection(UnityAction<Int32> callback) { }

	public override void Send(Guid messageId, Byte[] data) { }

	public override bool TrySend(Guid messageId, Byte[] data) { }

	public override void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public override void UnregisterConnection(UnityAction<Int32> callback) { }

	public override void UnregisterDisconnection(UnityAction<Int32> callback) { }

}

