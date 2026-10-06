namespace Mono.Net.Security;

internal class ChainValidationHelper : ICertificateValidator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public MonoTlsSettings settings; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

	}

	private readonly WeakReference<SslStream> owner; //Field offset: 0x10
	private readonly MonoTlsSettings settings; //Field offset: 0x18
	private readonly MobileTlsProvider provider; //Field offset: 0x20
	private readonly ServerCertValidationCallback certValidationCallback; //Field offset: 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; //Field offset: 0x30
	private readonly MonoTlsStream tlsStream; //Field offset: 0x38
	private readonly HttpWebRequest request; //Field offset: 0x40

	public override MonoTlsSettings Settings
	{
		 get { } //Length: 5
	}

	private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	public override MonoTlsSettings get_Settings() { }

	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }

	public override bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, out X509Certificate clientCertificate) { }

	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

