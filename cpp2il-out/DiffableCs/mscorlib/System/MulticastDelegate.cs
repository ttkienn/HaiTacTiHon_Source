namespace System;

[ComVisible(True)]
public abstract class MulticastDelegate : Delegate
{
	private Delegate[] delegates; //Field offset: 0x78

	protected virtual Delegate CombineImpl(Delegate follow) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual Delegate[] GetInvocationList() { }

	protected virtual MethodInfo GetMethodImpl() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	protected virtual Delegate RemoveImpl(Delegate value) { }

}

