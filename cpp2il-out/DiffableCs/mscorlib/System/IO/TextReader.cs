namespace System.IO;

public abstract class TextReader : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Object, Int32> <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ReadAsyncInternal>b__17_0(object state) { }

	}

	private sealed class NullTextReader : TextReader
	{

		public NullTextReader() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

	}

	public sealed class SyncTextReader : TextReader
	{
		internal readonly TextReader _in; //Field offset: 0x18

		internal SyncTextReader(TextReader t) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		public virtual Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

	}

	public static readonly TextReader Null; //Field offset: 0x0

	private static TextReader() { }

	protected TextReader() { }

	public override void Close() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(Char[] buffer, int index, int count) { }

	public override int Read(Span<Char> buffer) { }

	public override Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

	internal override ValueTask<Int32> ReadAsyncInternal(Memory<Char> buffer, CancellationToken cancellationToken) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

	public static TextReader Synchronized(TextReader reader) { }

}

