namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	private static Dictionary<String, Object> type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress; //Field offset: 0x80000008
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000010
	private static string _process_guid; //Field offset: 0x0
	private IntPtr _mono_app_domain; //Field offset: 0x18
	private object _evidence; //Field offset: 0x20
	private object _granted; //Field offset: 0x28
	private int _principalPolicy; //Field offset: 0x30
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; //Field offset: 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; //Field offset: 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x68
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x70
	private object _domain_manager; //Field offset: 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x80
	private object _activation; //Field offset: 0x88
	private object _applicationIdentity; //Field offset: 0x90
	private List<String> compatibility_switch; //Field offset: 0x98

	public override event ResolveEventHandler AssemblyResolve
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event EventHandler DomainUnload
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static AppDomain CurrentDomain
	{
		 get { } //Length: 5
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	[MonoTODO]
	public bool IsHomogenous
	{
		 get { } //Length: 3
	}

	private AppDomain() { }

	[CompilerGenerated]
	public override void add_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	private void DoDomainUnload() { }

	internal Assembly DoTypeResolve(string name) { }

	public static AppDomain get_CurrentDomain() { }

	public bool get_IsFullyTrusted() { }

	public bool get_IsHomogenous() { }

	public override Assembly[] GetAssemblies() { }

	private Assembly[] GetAssemblies(bool refOnly) { }

	private static AppDomain getCurDomain() { }

	public override object GetData(string name) { }

	private int getDomainID() { }

	private string getFriendlyName() { }

	internal Byte[] GetMarshalledDomainObjRef() { }

	internal static string GetProcessGuid() { }

	public virtual object InitializeLifetimeService() { }

	internal static Context InternalGetContext() { }

	internal static Context InternalGetDefaultContext() { }

	internal static string InternalGetProcessGuid(string newguid) { }

	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	internal static void InternalPopDomainRef() { }

	internal static void InternalPushDomainRefByID(int domain_id) { }

	internal static Context InternalSetContext(Context context) { }

	private static AppDomain InternalSetDomain(AppDomain context) { }

	private static AppDomain InternalSetDomainByID(int domain_id) { }

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, Object[] args) { }

	[Intrinsic]
	internal static bool IsAppXModel() { }

	public bool IsFinalizingForUnload() { }

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	public override Assembly Load(string assemblyString) { }

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	internal void ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg, out Byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGenerated]
	public override void remove_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	public virtual string ToString() { }

}

