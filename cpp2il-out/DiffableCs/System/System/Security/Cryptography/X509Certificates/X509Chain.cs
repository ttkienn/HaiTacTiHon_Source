namespace System.Security.Cryptography.X509Certificates;

public class X509Chain : IDisposable
{
	private X509ChainImpl impl; //Field offset: 0x10

	public X509ChainElementCollection ChainElements
	{
		 get { } //Length: 114
	}

	public X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 114
	}

	internal X509ChainImpl Impl
	{
		internal get { } //Length: 84
	}

	public X509Chain() { }

	public X509Chain(bool useMachineContext) { }

	internal X509Chain(X509ChainImpl impl) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	public X509Chain(IntPtr chainContext) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	public bool Build(X509Certificate2 certificate) { }

	public static X509Chain Create() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public X509ChainElementCollection get_ChainElements() { }

	public X509ChainPolicy get_ChainPolicy() { }

	internal X509ChainImpl get_Impl() { }

	public void Reset() { }

}

