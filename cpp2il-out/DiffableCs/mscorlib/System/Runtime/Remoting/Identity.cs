namespace System.Runtime.Remoting;

internal abstract class Identity
{
	protected string _objectUri; //Field offset: 0x10
	protected IMessageSink _channelSink; //Field offset: 0x18
	protected IMessageSink _envoySink; //Field offset: 0x20
	private DynamicPropertyCollection _clientDynamicProperties; //Field offset: 0x28
	private DynamicPropertyCollection _serverDynamicProperties; //Field offset: 0x30
	protected ObjRef _objRef; //Field offset: 0x38
	private bool _disposed; //Field offset: 0x40

	public IMessageSink ChannelSink
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public DynamicPropertyCollection ClientDynamicProperties
	{
		 get { } //Length: 188
	}

	public bool Disposed
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public IMessageSink EnvoySink
	{
		 get { } //Length: 5
	}

	public bool HasServerDynamicSinks
	{
		 get { } //Length: 65
	}

	public bool IsConnected
	{
		 get { } //Length: 9
	}

	public string ObjectUri
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Identity(string objectUri) { }

	public abstract ObjRef CreateObjRef(Type requestedType) { }

	public IMessageSink get_ChannelSink() { }

	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	public bool get_Disposed() { }

	public IMessageSink get_EnvoySink() { }

	public bool get_HasServerDynamicSinks() { }

	public bool get_IsConnected() { }

	public string get_ObjectUri() { }

	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	public void set_ChannelSink(IMessageSink value) { }

	public void set_Disposed(bool value) { }

	public void set_ObjectUri(string value) { }

}

