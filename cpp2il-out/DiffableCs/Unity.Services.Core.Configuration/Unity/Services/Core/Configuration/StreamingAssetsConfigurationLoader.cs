namespace Unity.Services.Core.Configuration;

internal class StreamingAssetsConfigurationLoader : IConfigurationLoader
{
	[CompilerGenerated]
	private struct <GetConfigAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; //Field offset: 0x8
		public StreamingAssetsConfigurationLoader <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IJsonSerializer m_Serializer; //Field offset: 0x10

	public StreamingAssetsConfigurationLoader(IJsonSerializer serializer) { }

	[AsyncStateMachine(typeof(<GetConfigAsync>d__2))]
	public override Task<SerializableProjectConfiguration> GetConfigAsync() { }

}

