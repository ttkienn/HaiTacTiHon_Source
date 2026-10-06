namespace System.Threading;

[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	private readonly CancellationCallbackInfo m_callbackInfo; //Field offset: 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; //Field offset: 0x8

	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(CancellationTokenRegistration other) { }

	public virtual int GetHashCode() { }

	public bool Unregister() { }

}

