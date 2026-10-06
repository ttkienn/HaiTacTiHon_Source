namespace System.Resources;

internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
{
	internal const int Version = 2; //Field offset: 0x0
	private Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x28
	private ResourceReader _defaultReader; //Field offset: 0x30
	private Dictionary<String, ResourceLocator> _caseInsensitiveTable; //Field offset: 0x38
	private bool _haveReadFromReader; //Field offset: 0x40

	internal RuntimeResourceSet(string fileName) { }

	internal RuntimeResourceSet(Stream stream) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	private IDictionaryEnumerator GetEnumeratorHelper() { }

	public virtual object GetObject(string key) { }

	public virtual object GetObject(string key, bool ignoreCase) { }

	private object GetObject(string key, bool ignoreCase, bool isString) { }

	public virtual string GetString(string key) { }

	public virtual string GetString(string key, bool ignoreCase) { }

	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<String, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

