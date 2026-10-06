namespace System.Resources;

public interface IResourceReader : IEnumerable, IDisposable
{

	public void Close() { }

	public IDictionaryEnumerator GetEnumerator() { }

}

