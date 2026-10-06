namespace System.Net.Security;

internal sealed class LocalCertSelectionCallback : MulticastDelegate
{

	public LocalCertSelectionCallback(object object, IntPtr method) { }

	public override X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

