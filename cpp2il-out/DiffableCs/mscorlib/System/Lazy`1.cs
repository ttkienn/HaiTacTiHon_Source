namespace System;

[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView`1))]
public class Lazy
{
	private LazyHelper _state; //Field offset: 0x0
	private Func<T> _factory; //Field offset: 0x0
	private T _value; //Field offset: 0x0

	public bool IsValueCreated
	{
		 get { } //Length: 27
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public T Value
	{
		 get { } //Length: 444
	}

	public Lazy`1() { }

	public Lazy`1(Func<T> valueFactory) { }

	private Lazy`1(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	private T CreateValue() { }

	private static T CreateViaDefaultConstructor() { }

	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }

	public bool get_IsValueCreated() { }

	public T get_Value() { }

	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }

	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }

	private void PublicationOnlyViaFactory(LazyHelper initializer) { }

	private void PublicationOnlyWaitForOtherThreadToPublish() { }

	public virtual string ToString() { }

	private void ViaConstructor() { }

	private void ViaFactory(LazyThreadSafetyMode mode) { }

}

