namespace Mono.Security.Interface;

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate
{

	public MonoLocalCertificateSelectionCallback(object object, IntPtr method) { }

	public override X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

