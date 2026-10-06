namespace System.Xml;

[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable
{

	public abstract int Count
	{
		 get { } //Length: 0
	}

	public override XmlNode ItemOf
	{
		 get { } //Length: 20
	}

	protected XmlNodeList() { }

	public abstract int get_Count() { }

	public override XmlNode get_ItemOf(int i) { }

	public abstract IEnumerator GetEnumerator() { }

	public abstract XmlNode Item(int index) { }

	protected override void PrivateDisposeNodeList() { }

	private override void System.IDisposable.Dispose() { }

}

