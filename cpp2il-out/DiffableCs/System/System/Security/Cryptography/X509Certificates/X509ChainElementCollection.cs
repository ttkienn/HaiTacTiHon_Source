namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 42
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 42
	}

	public X509ChainElement Item
	{
		 get { } //Length: 152
	}

	public override object SyncRoot
	{
		 get { } //Length: 42
	}

	internal X509ChainElementCollection() { }

	internal void Add(X509Certificate2 certificate) { }

	internal void Clear() { }

	internal bool Contains(X509Certificate2 certificate) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public X509ChainElement get_Item(int index) { }

	public override object get_SyncRoot() { }

	public X509ChainElementEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

