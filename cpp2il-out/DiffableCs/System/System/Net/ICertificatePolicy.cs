namespace System.Net;

public interface ICertificatePolicy
{

	public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

