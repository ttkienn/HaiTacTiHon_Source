namespace Mono.Net.Security.Private;

internal static class CallbackHelpers
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public RemoteCertificateValidationCallback callback; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public MonoLocalCertificateSelectionCallback callback; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}


	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

}

