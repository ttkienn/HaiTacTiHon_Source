namespace System.Collections;

public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 48
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 161
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 48
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 48
	}

	protected ReadOnlyCollectionBase() { }

	public override int get_Count() { }

	protected ArrayList get_InnerList() { }

	public override IEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

}

