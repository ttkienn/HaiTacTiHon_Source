namespace System.Runtime.Remoting;

[ComVisible(True)]
public class ObjRef : IObjectReference, ISerializable
{
	private static int MarshalledObjectRef; //Field offset: 0x0
	private static int WellKnowObjectRef; //Field offset: 0x4
	private IChannelInfo channel_info; //Field offset: 0x10
	private string uri; //Field offset: 0x18
	private IRemotingTypeInfo typeInfo; //Field offset: 0x20
	private IEnvoyInfo envoyInfo; //Field offset: 0x28
	private int flags; //Field offset: 0x30
	private Type _serverType; //Field offset: 0x38

	public override IChannelInfo ChannelInfo
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 5
	}

	public override IEnvoyInfo EnvoyInfo
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	internal bool IsReferenceToWellKnow
	{
		internal get { } //Length: 90
	}

	internal Type ServerType
	{
		internal get { } //Length: 224
	}

	public override IRemotingTypeInfo TypeInfo
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public override string URI
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	private static ObjRef() { }

	protected ObjRef(SerializationInfo info, StreamingContext context) { }

	internal ObjRef(Type type, string url, object remoteChannelData) { }

	public ObjRef() { }

	internal ObjRef(string uri, IChannelInfo cinfo) { }

	internal ObjRef DeserializeInTheCurrentDomain(int domainId, Byte[] tInfo) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public override IChannelInfo get_ChannelInfo() { }

	public override IEnvoyInfo get_EnvoyInfo() { }

	internal bool get_IsReferenceToWellKnow() { }

	internal Type get_ServerType() { }

	public override IRemotingTypeInfo get_TypeInfo() { }

	public override string get_URI() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override object GetRealObject(StreamingContext context) { }

	internal Byte[] SerializeType() { }

	public override void set_EnvoyInfo(IEnvoyInfo value) { }

	public override void set_TypeInfo(IRemotingTypeInfo value) { }

	public override void set_URI(string value) { }

	internal void UpdateChannelInfo() { }

}

