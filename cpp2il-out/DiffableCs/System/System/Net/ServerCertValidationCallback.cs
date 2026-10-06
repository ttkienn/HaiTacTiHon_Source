namespace System.Net;

internal class ServerCertValidationCallback
{
	private class CallbackContext
	{
		internal readonly object request; //Field offset: 0x10
		internal readonly X509Certificate certificate; //Field offset: 0x18
		internal readonly X509Chain chain; //Field offset: 0x20
		internal readonly SslPolicyErrors sslPolicyErrors; //Field offset: 0x28
		internal bool result; //Field offset: 0x2C

		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	private readonly RemoteCertificateValidationCallback m_ValidationCallback; //Field offset: 0x10
	private readonly ExecutionContext m_Context; //Field offset: 0x18

	internal RemoteCertificateValidationCallback ValidationCallback
	{
		internal get { } //Length: 5
	}

	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) { }

	internal void Callback(object state) { }

	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

