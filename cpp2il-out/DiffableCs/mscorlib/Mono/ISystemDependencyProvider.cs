namespace Mono;

internal interface ISystemDependencyProvider
{

	public ISystemCertificateProvider CertificateProvider
	{
		 get { } //Length: 0
	}

	public ISystemCertificateProvider get_CertificateProvider() { }

}

