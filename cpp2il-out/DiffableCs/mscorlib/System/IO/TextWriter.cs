namespace System.IO;

public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__56_0; //Field offset: 0x8
		public static Action<Object> <>9__57_0; //Field offset: 0x10
		public static Action<Object> <>9__59_0; //Field offset: 0x18
		public static Action<Object> <>9__67_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <FlushAsync>b__67_0(object state) { }

		internal void <WriteAsync>b__56_0(object state) { }

		internal void <WriteAsync>b__57_0(object state) { }

		internal void <WriteAsync>b__59_0(object state) { }

	}

	private sealed class NullTextWriter : TextWriter
	{

		public virtual Encoding Encoding
		{
			 get { } //Length: 7
		}

		internal NullTextWriter() { }

		public virtual Encoding get_Encoding() { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(string value) { }

		public virtual void Write(char value) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(string value) { }

	}

	public sealed class SyncTextWriter : TextWriter, IDisposable
	{
		private readonly TextWriter _out; //Field offset: 0x30

		public virtual Encoding Encoding
		{
			 get { } //Length: 42
		}

		public virtual IFormatProvider FormatProvider
		{
			 get { } //Length: 42
		}

		public virtual string NewLine
		{
			 get { } //Length: 42
		}

		internal SyncTextWriter(TextWriter t) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual void Flush() { }

		public virtual Task FlushAsync() { }

		public virtual Encoding get_Encoding() { }

		public virtual IFormatProvider get_FormatProvider() { }

		public virtual string get_NewLine() { }

		public virtual void Write(char value) { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(string value) { }

		public virtual void Write(Char[] buffer) { }

		public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

		public virtual Task WriteAsync(char value) { }

		public virtual Task WriteAsync(string value) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(string value) { }

		public virtual void WriteLine(string format, object arg0) { }

	}

	public static readonly TextWriter Null; //Field offset: 0x0
	private static readonly Char[] s_coreNewLine; //Field offset: 0x8
	protected Char[] CoreNewLine; //Field offset: 0x18
	private string CoreNewLineStr; //Field offset: 0x20
	private IFormatProvider _internalFormatProvider; //Field offset: 0x28

	public abstract Encoding Encoding
	{
		 get { } //Length: 0
	}

	public override IFormatProvider FormatProvider
	{
		 get { } //Length: 87
	}

	public override string NewLine
	{
		 get { } //Length: 5
	}

	private static TextWriter() { }

	protected TextWriter() { }

	protected TextWriter(IFormatProvider formatProvider) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public override void Flush() { }

	public override Task FlushAsync() { }

	public abstract Encoding get_Encoding() { }

	public override IFormatProvider get_FormatProvider() { }

	public override string get_NewLine() { }

	public static TextWriter Synchronized(TextWriter writer) { }

	public override void Write(Char[] buffer, int index, int count) { }

	public override void Write(char value) { }

	public override void Write(string value) { }

	public override void Write(Char[] buffer) { }

	public override Task WriteAsync(char value) { }

	public override Task WriteAsync(string value) { }

	public override Task WriteAsync(Char[] buffer, int index, int count) { }

	public override void WriteLine() { }

	public override void WriteLine(string value) { }

	public override void WriteLine(string format, object arg0) { }

}

