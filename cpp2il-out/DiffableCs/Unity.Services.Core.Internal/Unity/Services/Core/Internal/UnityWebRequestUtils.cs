namespace Unity.Services.Core.Internal;

[Extension]
internal static class UnityWebRequestUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public TaskCompletionSource<String> completionSource; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(AsyncOperation rawOperation) { }

	}

	public const string JsonContentType = "application/json"; //Field offset: 0x0

	public static Task<String> GetTextAsync(string uri) { }

	[Extension]
	public static bool HasSucceeded(UnityWebRequest self) { }

}

