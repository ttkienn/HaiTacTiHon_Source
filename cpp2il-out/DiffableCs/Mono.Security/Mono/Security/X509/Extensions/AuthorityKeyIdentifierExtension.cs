namespace Mono.Security.X509.Extensions;

public class AuthorityKeyIdentifierExtension : X509Extension
{
	private Byte[] aki; //Field offset: 0x28

	public Byte[] Identifier
	{
		 get { } //Length: 123
	}

	public AuthorityKeyIdentifierExtension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public Byte[] get_Identifier() { }

	public virtual string ToString() { }

}

