namespace System;

public sealed class CharEnumerator : IEnumerator, IEnumerator<Char>, IDisposable, ICloneable
{
	private string _str; //Field offset: 0x10
	private int _index; //Field offset: 0x18
	private char _currentElement; //Field offset: 0x1C

	public override char Current
	{
		 get { } //Length: 194
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 247
	}

	internal CharEnumerator(string str) { }

	internal CharEnumerator() { }

	public override object Clone() { }

	public override void Dispose() { }

	public override char get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

