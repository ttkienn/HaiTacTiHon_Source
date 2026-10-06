namespace Mono.Security.X509.Extensions;

public class BasicConstraintsExtension : X509Extension
{
	private bool cA; //Field offset: 0x28
	private int pathLenConstraint; //Field offset: 0x2C

	public bool CertificateAuthority
	{
		 get { } //Length: 5
	}

	public BasicConstraintsExtension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public bool get_CertificateAuthority() { }

	public virtual string ToString() { }

}

