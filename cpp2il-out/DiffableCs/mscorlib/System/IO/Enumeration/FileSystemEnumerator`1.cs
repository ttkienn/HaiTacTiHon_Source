namespace System.IO.Enumeration;

public abstract class FileSystemEnumerator : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	private readonly string _originalRootDirectory; //Field offset: 0x0
	private readonly string _rootDirectory; //Field offset: 0x0
	private readonly EnumerationOptions _options; //Field offset: 0x0
	private readonly object _lock; //Field offset: 0x0
	private FILE_FULL_DIR_INFORMATION* _entry; //Field offset: 0x0
	private TResult _current; //Field offset: 0x0
	private IntPtr _buffer; //Field offset: 0x0
	private int _bufferLength; //Field offset: 0x0
	private IntPtr _directoryHandle; //Field offset: 0x0
	private string _currentPath; //Field offset: 0x0
	private bool _lastEntryFound; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Handle", "Path"}])]
	private Queue<ValueTuple`2<IntPtr, String>> _pending; //Field offset: 0x0

	public override TResult Current
	{
		 get { } //Length: 5
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 5
	}

	public FileSystemEnumerator`1(string directory, EnumerationOptions options = null) { }

	private void CloseDirectoryHandle() { }

	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }

	protected override bool ContinueOnError(int error) { }

	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false) { }

	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<Char> relativePath, string fullPath) { }

	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<Char> relativePath, string fullPath) { }

	private bool DequeueNextDirectory() { }

	private void DirectoryFinished() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	private void FindNextEntry() { }

	public override TResult get_Current() { }

	private bool GetData() { }

	private bool GetDataUWP() { }

	private void InternalDispose(bool disposing) { }

	public override bool MoveNext() { }

	protected override void OnDirectoryFinished(ReadOnlySpan<Char> directory) { }

	public override void Reset() { }

	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	protected abstract TResult TransformEntry(ref FileSystemEntry entry) { }

}

