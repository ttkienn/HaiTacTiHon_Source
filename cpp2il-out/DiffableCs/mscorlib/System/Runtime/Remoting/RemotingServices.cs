namespace System.Runtime.Remoting;

[ComVisible(True)]
public static class RemotingServices
{
	private class CACD
	{
		public object d; //Field offset: 0x10
		public object c; //Field offset: 0x18

		public CACD() { }

	}

	private static Hashtable uri_hash; //Field offset: 0x0
	private static BinaryFormatter _serializationFormatter; //Field offset: 0x8
	private static BinaryFormatter _deserializationFormatter; //Field offset: 0x10
	private static string app_id; //Field offset: 0x18
	private static readonly object app_id_lock; //Field offset: 0x20
	private static int next_id; //Field offset: 0x28
	private static readonly MethodInfo FieldSetterMethod; //Field offset: 0x30
	private static readonly MethodInfo FieldGetterMethod; //Field offset: 0x38

	private static RemotingServices() { }

	[ComVisible(True)]
	public static object Connect(Type classToProxy, string url, object data) { }

	[ComVisible(True)]
	public static object Connect(Type classToProxy, string url) { }

	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, Object[] activationAttributes) { }

	internal static object CreateClientProxy(Type objectType, string url, Object[] activationAttributes) { }

	internal static object CreateClientProxyForContextBound(Type type, Object[] activationAttributes) { }

	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	internal static object DeserializeCallData(Byte[] array) { }

	internal static void DisposeIdentity(Identity ident) { }

	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	internal static Identity GetIdentityForUri(string uri) { }

	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	private static string GetNormalizedUri(string uri) { }

	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static RealProxy GetRealProxy(object proxy) { }

	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	public static Type GetServerTypeForUri(string URI) { }

	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	internal static object InternalExecute(MethodBase method, object obj, Object[] parameters, out Object[] out_args) { }

	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	public static bool IsOneWay(MethodBase method) { }

	public static bool IsTransparentProxy(object proxy) { }

	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	private static string NewUri() { }

	private static void RegisterInternalChannels() { }

	private static void RegisterServerIdentity(ServerIdentity identity) { }

	private static string RemoveAppNameFromUri(string uri) { }

	internal static Byte[] SerializeCallData(object obj) { }

	internal static Byte[] SerializeExceptionData(Exception ex) { }

	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	public static object Unmarshal(ObjRef objectRef) { }

	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

}

