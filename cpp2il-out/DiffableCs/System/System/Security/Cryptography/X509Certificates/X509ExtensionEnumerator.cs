namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public X509Extension Current
	{
		 get { } //Length: 149
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 73
	}

	internal X509ExtensionEnumerator(ArrayList list) { }

	public X509Extension get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

