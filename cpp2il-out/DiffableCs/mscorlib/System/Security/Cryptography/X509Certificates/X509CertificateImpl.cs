namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509CertificateImpl : IDisposable
{

	public abstract bool HasPrivateKey
	{
		 get { } //Length: 0
	}

	public abstract string Issuer
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	public abstract string KeyAlgorithm
	{
		 get { } //Length: 0
	}

	public abstract Byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotAfter
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotBefore
	{
		 get { } //Length: 0
	}

	public abstract Byte[] PublicKeyValue
	{
		 get { } //Length: 0
	}

	public abstract Byte[] RawData
	{
		 get { } //Length: 0
	}

	public abstract Byte[] SerialNumber
	{
		 get { } //Length: 0
	}

	public abstract string Subject
	{
		 get { } //Length: 0
	}

	public abstract Byte[] Thumbprint
	{
		 get { } //Length: 0
	}

	protected X509CertificateImpl() { }

	public abstract X509CertificateImpl Clone() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public abstract Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	protected virtual void Finalize() { }

	public abstract bool get_HasPrivateKey() { }

	public abstract string get_Issuer() { }

	public abstract bool get_IsValid() { }

	public abstract string get_KeyAlgorithm() { }

	public abstract Byte[] get_KeyAlgorithmParameters() { }

	public abstract DateTime get_NotAfter() { }

	public abstract DateTime get_NotBefore() { }

	public abstract Byte[] get_PublicKeyValue() { }

	public abstract Byte[] get_RawData() { }

	public abstract Byte[] get_SerialNumber() { }

	public abstract string get_Subject() { }

	public abstract Byte[] get_Thumbprint() { }

	public abstract DSA GetDSAPrivateKey() { }

	public virtual int GetHashCode() { }

	public abstract RSA GetRSAPrivateKey() { }

	protected void ThrowIfContextInvalid() { }

}

