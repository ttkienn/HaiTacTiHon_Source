namespace System.IO.Enumeration;

public class FileSystemEnumerable : IEnumerable<TResult>, IEnumerable
{
	private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
	{
		private readonly FileSystemEnumerable<TResult> _enumerable; //Field offset: 0x0

		public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable) { }

		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

		protected virtual TResult TransformEntry(ref FileSystemEntry entry) { }

	}

	internal sealed class FindPredicate : MulticastDelegate
	{

		public FindPredicate(object object, IntPtr method) { }

		public override bool Invoke(ref FileSystemEntry entry) { }

	}

	internal sealed class FindTransform : MulticastDelegate
	{

		public FindTransform(object object, IntPtr method) { }

		public override TResult Invoke(ref FileSystemEntry entry) { }

	}

	private DelegateEnumerator<TResult> _enumerator; //Field offset: 0x0
	private readonly FindTransform<TResult> _transform; //Field offset: 0x0
	private readonly EnumerationOptions _options; //Field offset: 0x0
	private readonly string _directory; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; //Field offset: 0x0

	public FindPredicate<TResult> ShouldIncludePredicate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public FindPredicate<TResult> ShouldRecursePredicate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FileSystemEnumerable`1(string directory, FindTransform<TResult> transform, EnumerationOptions options = null) { }

	[CompilerGenerated]
	public FindPredicate<TResult> get_ShouldIncludePredicate() { }

	[CompilerGenerated]
	public FindPredicate<TResult> get_ShouldRecursePredicate() { }

	public override IEnumerator<TResult> GetEnumerator() { }

	[CompilerGenerated]
	public void set_ShouldIncludePredicate(FindPredicate<TResult> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

