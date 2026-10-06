namespace System.Xml;

internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{

	internal virtual bool IsFull
	{
		internal get { } //Length: 3
	}

	public IncrementalReadDummyDecoder() { }

	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	internal virtual bool get_IsFull() { }

}

