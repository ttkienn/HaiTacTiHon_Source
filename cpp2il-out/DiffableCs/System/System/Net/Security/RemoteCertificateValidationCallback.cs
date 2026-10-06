namespace System.Net.Security;

public sealed class RemoteCertificateValidationCallback : MulticastDelegate
{

	public RemoteCertificateValidationCallback(object object, IntPtr method) { }

	public override bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

