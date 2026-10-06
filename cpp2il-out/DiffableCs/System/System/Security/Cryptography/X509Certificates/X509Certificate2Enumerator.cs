namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Certificate2Enumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public X509Certificate2 Current
	{
		 get { } //Length: 149
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 73
	}

	internal X509Certificate2Enumerator(X509Certificate2Collection collection) { }

	public X509Certificate2 get_Current() { }

	public bool MoveNext() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

