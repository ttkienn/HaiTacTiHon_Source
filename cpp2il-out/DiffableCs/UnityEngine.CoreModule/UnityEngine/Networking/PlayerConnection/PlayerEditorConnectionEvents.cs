namespace UnityEngine.Networking.PlayerConnection;

internal class PlayerEditorConnectionEvents
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Guid messageId; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <InvokeMessageIdSubscribers>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Guid messageId; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <AddAndCreate>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Guid messageId; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <UnregisterManagedCallback>b__0(MessageTypeSubscribers x) { }

	}

	internal class ConnectionChangeEvent : UnityEvent<Int32>
	{

		public ConnectionChangeEvent() { }

	}

	internal class MessageEvent : UnityEvent<MessageEventArgs>
	{

		public MessageEvent() { }

	}

	internal class MessageTypeSubscribers
	{
		[SerializeField]
		private string m_messageTypeId; //Field offset: 0x10
		public int subscriberCount; //Field offset: 0x18
		public MessageEvent messageCallback; //Field offset: 0x20

		public Guid MessageTypeId
		{
			 get { } //Length: 54
			 set { } //Length: 44
		}

		public MessageTypeSubscribers() { }

		public Guid get_MessageTypeId() { }

		public void set_MessageTypeId(Guid value) { }

	}

	[SerializeField]
	public List<MessageTypeSubscribers> messageTypeSubscribers; //Field offset: 0x10
	[SerializeField]
	public ConnectionChangeEvent connectionEvent; //Field offset: 0x18
	[SerializeField]
	public ConnectionChangeEvent disconnectionEvent; //Field offset: 0x20

	public PlayerEditorConnectionEvents() { }

	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

