namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509ChainImpl : IDisposable
{

	public abstract X509ChainElementCollection ChainElements
	{
		 get { } //Length: 0
	}

	public abstract X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	protected X509ChainImpl() { }

	public abstract void AddStatus(X509ChainStatusFlags errorCode) { }

	public abstract bool Build(X509Certificate2 certificate) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public abstract X509ChainElementCollection get_ChainElements() { }

	public abstract X509ChainPolicy get_ChainPolicy() { }

	public abstract bool get_IsValid() { }

	public abstract void Reset() { }

	protected void ThrowIfContextInvalid() { }

}

