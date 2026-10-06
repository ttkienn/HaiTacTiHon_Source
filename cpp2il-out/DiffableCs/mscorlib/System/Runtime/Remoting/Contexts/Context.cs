namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public class Context
{
	[ContextStatic]
	private static Object[] local_slots; //Field offset: 0x0
	private static IMessageSink default_server_context_sink; //Field offset: 0x8
	private static int global_count; //Field offset: 0x10
	private static LocalDataStoreMgr _localDataStoreMgr; //Field offset: 0x18
	private static DynamicPropertyCollection global_dynamic_properties; //Field offset: 0x20
	private int domain_id; //Field offset: 0x10
	private int context_id; //Field offset: 0x14
	private UIntPtr static_data; //Field offset: 0x18
	private UIntPtr data; //Field offset: 0x20
	private IMessageSink server_context_sink_chain; //Field offset: 0x28
	private IMessageSink client_context_sink_chain; //Field offset: 0x30
	private List<IContextProperty> context_properties; //Field offset: 0x38
	private LocalDataStoreHolder _localDataStore; //Field offset: 0x40
	private DynamicPropertyCollection context_dynamic_properties; //Field offset: 0x48
	private ContextCallbackObject callback_object; //Field offset: 0x50

	public override int ContextID
	{
		 get { } //Length: 4
	}

	public override IContextProperty[] ContextProperties
	{
		 get { } //Length: 96
	}

	public static Context DefaultContext
	{
		 get { } //Length: 7
	}

	internal bool HasDynamicSinks
	{
		internal get { } //Length: 65
	}

	internal bool HasExitSinks
	{
		internal get { } //Length: 365
	}

	internal static bool HasGlobalDynamicSinks
	{
		internal get { } //Length: 161
	}

	internal bool IsDefaultContext
	{
		internal get { } //Length: 8
	}

	private LocalDataStore MyLocalStore
	{
		private get { } //Length: 369
	}

	internal bool NeedsContextSink
	{
		internal get { } //Length: 229
	}

	private static Context() { }

	public Context() { }

	public static LocalDataStoreSlot AllocateDataSlot() { }

	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	public void DoCallBack(CrossContextDelegate deleg) { }

	protected virtual void Finalize() { }

	public static void FreeNamedDataSlot(string name) { }

	public override void Freeze() { }

	public override int get_ContextID() { }

	public override IContextProperty[] get_ContextProperties() { }

	public static Context get_DefaultContext() { }

	internal bool get_HasDynamicSinks() { }

	internal bool get_HasExitSinks() { }

	internal static bool get_HasGlobalDynamicSinks() { }

	internal bool get_IsDefaultContext() { }

	private LocalDataStore get_MyLocalStore() { }

	internal bool get_NeedsContextSink() { }

	internal IMessageSink GetClientContextSinkChain() { }

	public static object GetData(LocalDataStoreSlot slot) { }

	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	public override IContextProperty GetProperty(string name) { }

	internal IMessageSink GetServerContextSinkChain() { }

	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	private static void RegisterContext(Context ctx) { }

	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	private static void ReleaseContext(Context ctx) { }

	public static void SetData(LocalDataStoreSlot slot, object data) { }

	public override void SetProperty(IContextProperty prop) { }

	internal static Context SwitchToContext(Context newContext) { }

	public virtual string ToString() { }

	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

}

