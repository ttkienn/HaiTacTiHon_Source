namespace Unity.Services.Core;

public static class UnityServices
{
	[CompilerGenerated]
	private struct <InitializeAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitializationOptions options; //Field offset: 0x20
		private TaskAwaiter<Object> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<Object> <InstantiationCompletion>k__BackingField; //Field offset: 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; //Field offset: 0x10
	[CompilerGenerated]
	private static readonly Dictionary<String, IUnityServices> <s_Services>k__BackingField; //Field offset: 0x18

	public static event Action Initialized
	{
		 add { } //Length: 257
		 remove { } //Length: 260
	}

	public static event Action<Exception> InitializeFailed
	{
		 add { } //Length: 260
		 remove { } //Length: 260
	}

	public static string ExternalUserId
	{
		 get { } //Length: 93
		 set { } //Length: 147
	}

	public static IUnityServices Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 105
	}

	internal static TaskCompletionSource<Object> InstantiationCompletion
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		internal set { } //Length: 110
	}

	private static Dictionary<String, IUnityServices> s_Services
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	public static IReadOnlyDictionary<String, IUnityServices> Services
	{
		 get { } //Length: 138
	}

	public static ServicesInitializationState State
	{
		 get { } //Length: 664
	}

	private static UnityServices() { }

	public static void add_Initialized(Action value) { }

	public static void add_InitializeFailed(Action<Exception> value) { }

	internal static void ClearServices() { }

	public static IUnityServices CreateServices(string servicesId) { }

	public static IUnityServices CreateServices() { }

	public static string get_ExternalUserId() { }

	[CompilerGenerated]
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	internal static TaskCompletionSource<Object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	private static Dictionary<String, IUnityServices> get_s_Services() { }

	public static IReadOnlyDictionary<String, IUnityServices> get_Services() { }

	public static ServicesInitializationState get_State() { }

	public static Task InitializeAsync() { }

	[AsyncStateMachine(typeof(<InitializeAsync>d__26))]
	[PreserveDependency("EnableServicesInitializationAsync()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("CreateStaticInstance()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("Register()", "Unity.Services.Core.Registration.CorePackageInitializer", "Unity.Services.Core.Registration")]
	[PreserveDependency("CaptureUnityThreadInfo()", "Unity.Services.Core.UnityThreadUtils", "Unity.Services.Core")]
	public static Task InitializeAsync(InitializationOptions options) { }

	public static void remove_Initialized(Action value) { }

	public static void remove_InitializeFailed(Action<Exception> value) { }

	public static void set_ExternalUserId(string value) { }

	[CompilerGenerated]
	public static void set_Instance(IUnityServices value) { }

	[CompilerGenerated]
	internal static void set_InstantiationCompletion(TaskCompletionSource<Object> value) { }

}

