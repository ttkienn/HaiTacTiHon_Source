namespace System;

public sealed class WeakReference : ISerializable
{
	private GCHandle handle; //Field offset: 0x0
	private bool trackResurrection; //Field offset: 0x0

	public WeakReference`1(T target) { }

	public WeakReference`1(T target, bool trackResurrection) { }

	private WeakReference`1(SerializationInfo info, StreamingContext context) { }

	protected virtual void Finalize() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public bool TryGetTarget(out T target) { }

}

