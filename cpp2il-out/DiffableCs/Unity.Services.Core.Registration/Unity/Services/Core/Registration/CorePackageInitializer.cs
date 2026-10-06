namespace Unity.Services.Core.Registration;

internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider
{
	[CompilerGenerated]
	private struct <CreateDiagnosticsComponents>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IDiagnosticsFactory> <>t__builder; //Field offset: 0x8
		public CorePackageInitializer <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GenerateProjectConfigurationAsync>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ProjectConfiguration> <>t__builder; //Field offset: 0x8
		public InitializationOptions options; //Field offset: 0x20
		public CorePackageInitializer <>4__this; //Field offset: 0x28
		private TaskAwaiter<SerializableProjectConfiguration> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSerializedConfigOrEmptyAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<SerializableProjectConfiguration> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSerializedProjectConfigurationAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public CorePackageInitializer <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeComponents>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CorePackageInitializer <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeProjectConfigAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CorePackageInitializer <>4__this; //Field offset: 0x20
		public InitializationOptions options; //Field offset: 0x28
		private TaskAwaiter<ProjectConfiguration> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private ActionScheduler <ActionScheduler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private InstallationId <InstallationId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ProjectConfiguration <ProjectConfig>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Environments <Environments>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ExternalUserId <ExternalUserId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ICloudProjectId <CloudProjectId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private IMetricsFactory <MetricsFactory>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; //Field offset: 0x50
	private CoreRegistry m_Registry; //Field offset: 0x58
	private readonly IJsonSerializer m_Serializer; //Field offset: 0x60
	private InitializationOptions m_CurrentInitializationOptions; //Field offset: 0x68

	internal ActionScheduler ActionScheduler
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal ICloudProjectId CloudProjectId
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal IDiagnosticsFactory DiagnosticsFactory
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal Environments Environments
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal ExternalUserId ExternalUserId
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal InstallationId InstallationId
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal IMetricsFactory MetricsFactory
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal ProjectConfiguration ProjectConfig
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal UnityThreadUtilsInternal UnityThreadUtils
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public CorePackageInitializer(IJsonSerializer serializer) { }

	[CompilerGenerated]
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	[CompilerGenerated]
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

	[AsyncStateMachine(typeof(<CreateDiagnosticsComponents>d__61))]
	public override Task<IDiagnosticsFactory> CreateDiagnosticsComponents() { }

	private void FreeOptionsDependantComponents() { }

	[AsyncStateMachine(typeof(<GenerateProjectConfigurationAsync>d__53))]
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	[CompilerGenerated]
	internal ActionScheduler get_ActionScheduler() { }

	[CompilerGenerated]
	internal ICloudProjectId get_CloudProjectId() { }

	[CompilerGenerated]
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	[CompilerGenerated]
	internal Environments get_Environments() { }

	[CompilerGenerated]
	internal ExternalUserId get_ExternalUserId() { }

	[CompilerGenerated]
	internal InstallationId get_InstallationId() { }

	[CompilerGenerated]
	internal IMetricsFactory get_MetricsFactory() { }

	[CompilerGenerated]
	internal ProjectConfiguration get_ProjectConfig() { }

	[CompilerGenerated]
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	[AsyncStateMachine(typeof(<GetSerializedConfigOrEmptyAsync>d__54))]
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	[AsyncStateMachine(typeof(<GetSerializedProjectConfigurationAsync>d__63))]
	public override Task<String> GetSerializedProjectConfigurationAsync() { }

	private bool HaveInitOptionsChanged() { }

	public override Task Initialize(CoreRegistry registry) { }

	internal void InitializeActionScheduler() { }

	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId = null) { }

	[AsyncStateMachine(typeof(<InitializeComponents>d__47))]
	private Task InitializeComponents() { }

	internal void InitializeDiagnostics() { }

	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	internal void InitializeInstallationId() { }

	public override Task InitializeInstanceAsync(CoreRegistry registry) { }

	internal void InitializeMetrics() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void InitializeOnLoad() { }

	[AsyncStateMachine(typeof(<InitializeProjectConfigAsync>d__52))]
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	internal void InitializeUnityThreadUtils() { }

	public override void Register(CorePackageRegistry registry) { }

	[CompilerGenerated]
	private void set_ActionScheduler(ActionScheduler value) { }

	[CompilerGenerated]
	private void set_CloudProjectId(ICloudProjectId value) { }

	[CompilerGenerated]
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	[CompilerGenerated]
	private void set_Environments(Environments value) { }

	[CompilerGenerated]
	private void set_ExternalUserId(ExternalUserId value) { }

	[CompilerGenerated]
	private void set_InstallationId(InstallationId value) { }

	[CompilerGenerated]
	private void set_MetricsFactory(IMetricsFactory value) { }

	[CompilerGenerated]
	private void set_ProjectConfig(ProjectConfiguration value) { }

	[CompilerGenerated]
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

}

