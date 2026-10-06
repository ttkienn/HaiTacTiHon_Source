namespace System.Xml;

internal sealed class EmptyEnumerator : IEnumerator
{

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 95
	}

	public EmptyEnumerator() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

