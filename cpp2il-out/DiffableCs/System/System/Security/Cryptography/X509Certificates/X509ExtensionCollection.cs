namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable
{
	private static Byte[] Empty; //Field offset: 0x0
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 42
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 42
	}

	public X509Extension Item
	{
		 get { } //Length: 637
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private static X509ExtensionCollection() { }

	public X509ExtensionCollection() { }

	public int Add(X509Extension extension) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public X509Extension get_Item(string oid) { }

	public override object get_SyncRoot() { }

	public X509ExtensionEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

