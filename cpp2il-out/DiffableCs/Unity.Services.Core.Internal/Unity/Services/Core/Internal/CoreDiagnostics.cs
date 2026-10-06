namespace Unity.Services.Core.Internal;

internal class CoreDiagnostics
{
	[CompilerGenerated]
	private struct <GetOrCreateDiagnosticsAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IDiagnostics> <>t__builder; //Field offset: 0x8
		public CoreDiagnostics <>4__this; //Field offset: 0x20
		private TaskAwaiter<IDiagnosticsFactory> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCoreDiagnosticsAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal const string CorePackageName = "com.unity.services.core"; //Field offset: 0x0
	internal const string CircularDependencyDiagnosticName = "circular_dependency"; //Field offset: 0x0
	internal const string CorePackageInitDiagnosticName = "core_package_init"; //Field offset: 0x0
	internal const string OperateServicesInitDiagnosticName = "operate_services_init"; //Field offset: 0x0
	internal const string ProjectConfigTagName = "project_config"; //Field offset: 0x0
	[CompilerGenerated]
	private static CoreDiagnostics <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IDictionary<String, String> <CoreTags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IDiagnostics <Diagnostics>k__BackingField; //Field offset: 0x20

	public IDictionary<String, String> CoreTags
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal IDiagnostics Diagnostics
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	internal IDiagnosticsComponentProvider DiagnosticsComponentProvider
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal static CoreDiagnostics Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		internal set { } //Length: 81
	}

	public CoreDiagnostics() { }

	[CompilerGenerated]
	public IDictionary<String, String> get_CoreTags() { }

	[CompilerGenerated]
	internal IDiagnostics get_Diagnostics() { }

	[CompilerGenerated]
	internal IDiagnosticsComponentProvider get_DiagnosticsComponentProvider() { }

	[CompilerGenerated]
	public static CoreDiagnostics get_Instance() { }

	[AsyncStateMachine(typeof(<GetOrCreateDiagnosticsAsync>d__26))]
	internal Task<IDiagnostics> GetOrCreateDiagnosticsAsync() { }

	private static void OnSendFailed(Task failedSendTask) { }

	public void SendCircularDependencyDiagnostics(Exception exception) { }

	[AsyncStateMachine(typeof(<SendCoreDiagnosticsAsync>d__24))]
	internal Task SendCoreDiagnosticsAsync(string diagnosticName, Exception exception) { }

	public void SendCorePackageInitDiagnostics(Exception exception) { }

	public void SendOperateServicesInitDiagnostics(Exception exception) { }

	[CompilerGenerated]
	internal void set_Diagnostics(IDiagnostics value) { }

	[CompilerGenerated]
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	[CompilerGenerated]
	internal static void set_Instance(CoreDiagnostics value) { }

	public void SetProjectConfiguration(string serializedProjectConfig) { }

}

