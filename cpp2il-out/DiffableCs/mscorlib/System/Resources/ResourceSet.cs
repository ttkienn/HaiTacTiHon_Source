namespace System.Resources;

[ComVisible(True)]
public class ResourceSet : IDisposable, IEnumerable
{
	protected IResourceReader Reader; //Field offset: 0x10
	protected Hashtable Table; //Field offset: 0x18
	private Hashtable _caseInsensitiveTable; //Field offset: 0x20

	protected ResourceSet() { }

	internal ResourceSet(bool junk) { }

	private void CommonInit() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	private object GetCaseInsensitiveObjectInternal(string name) { }

	[ComVisible(False)]
	public override IDictionaryEnumerator GetEnumerator() { }

	private IDictionaryEnumerator GetEnumeratorHelper() { }

	public override object GetObject(string name) { }

	public override object GetObject(string name, bool ignoreCase) { }

	private object GetObjectInternal(string name) { }

	public override string GetString(string name) { }

	public override string GetString(string name, bool ignoreCase) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

