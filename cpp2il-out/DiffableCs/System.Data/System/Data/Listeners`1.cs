namespace System.Data;

internal sealed class Listeners
{
	public sealed class Action : MulticastDelegate
	{

		public Action`4(object object, IntPtr method) { }

		public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	}

	public sealed class Func : MulticastDelegate
	{

		public Func`2(object object, IntPtr method) { }

		public override TResult Invoke(T1 arg1) { }

	}

	private readonly List<TElem> _listeners; //Field offset: 0x0
	private readonly Func<TElem, TElem, Boolean> _filter; //Field offset: 0x0
	private readonly int _objectID; //Field offset: 0x0
	private int _listenerReaderCount; //Field offset: 0x0

	internal bool HasListeners
	{
		internal get { } //Length: 30
	}

	internal Listeners`1(int ObjectID, Func<TElem, TElem, Boolean> notifyFilter) { }

	internal void Add(TElem listener) { }

	internal bool get_HasListeners() { }

	internal int IndexOfReference(TElem listener) { }

	internal void Notify(T1 arg1, T2 arg2, T3 arg3, Action<TElem, TElem, T1, T2, T3> action) { }

	internal void Remove(TElem listener) { }

	private void RemoveNullListeners(int nullIndex) { }

}

