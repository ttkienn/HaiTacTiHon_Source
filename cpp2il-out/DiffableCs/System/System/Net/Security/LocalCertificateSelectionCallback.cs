namespace System.Net.Security;

public sealed class LocalCertificateSelectionCallback : MulticastDelegate
{

	public LocalCertificateSelectionCallback(object object, IntPtr method) { }

	public override X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

