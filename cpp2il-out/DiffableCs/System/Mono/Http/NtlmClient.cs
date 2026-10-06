namespace Mono.Http;

internal class NtlmClient : IAuthenticationModule
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

	}

	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; //Field offset: 0x0

	public override string AuthenticationType
	{
		 get { } //Length: 44
	}

	private static NtlmClient() { }

	public NtlmClient() { }

	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public override string get_AuthenticationType() { }

	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

