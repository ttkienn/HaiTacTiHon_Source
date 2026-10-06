namespace Mono.Security.Interface;

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
{

	public MonoRemoteCertificateValidationCallback(object object, IntPtr method) { }

	public override bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

