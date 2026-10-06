namespace System.Security.Util;

internal sealed class Tokenizer
{
	public interface ITokenReader
	{

		public int Read() { }

	}

	public class StreamTokenReader : ITokenReader
	{
		internal StreamReader _in; //Field offset: 0x10
		internal int _numCharRead; //Field offset: 0x18

		internal int NumCharEncountered
		{
			internal get { } //Length: 4
		}

		internal StreamTokenReader(StreamReader input) { }

		internal int get_NumCharEncountered() { }

		public override int Read() { }

	}

	public sealed class StringMaker
	{
		private String[] aStrings; //Field offset: 0x10
		private uint cStringsMax; //Field offset: 0x18
		private uint cStringsUsed; //Field offset: 0x1C
		public StringBuilder _outStringBuilder; //Field offset: 0x20
		public Char[] _outChars; //Field offset: 0x28
		public int _outIndex; //Field offset: 0x30

		public StringMaker() { }

		private bool CompareStringAndChars(string str, Char[] a, int l) { }

		private static uint HashCharArray(Char[] a, int l) { }

		private static uint HashString(string str) { }

		public string MakeString() { }

	}

	private enum TokenSource
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6,
	}

	public int LineNo; //Field offset: 0x10
	private int _inProcessingTag; //Field offset: 0x14
	private Byte[] _inBytes; //Field offset: 0x18
	private Char[] _inChars; //Field offset: 0x20
	private string _inString; //Field offset: 0x28
	private int _inIndex; //Field offset: 0x30
	private int _inSize; //Field offset: 0x34
	private int _inSavedCharacter; //Field offset: 0x38
	private TokenSource _inTokenSource; //Field offset: 0x3C
	private ITokenReader _inTokenReader; //Field offset: 0x40
	private StringMaker _maker; //Field offset: 0x48
	private String[] _searchStrings; //Field offset: 0x50
	private String[] _replaceStrings; //Field offset: 0x58
	private int _inNestedIndex; //Field offset: 0x60
	private int _inNestedSize; //Field offset: 0x64
	private string _inNestedString; //Field offset: 0x68

	internal Tokenizer(string input) { }

	internal void BasicInitialization() { }

	internal void ChangeFormat(Encoding encoding) { }

	private string GetStringToken() { }

	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	public void Recycle() { }

}

