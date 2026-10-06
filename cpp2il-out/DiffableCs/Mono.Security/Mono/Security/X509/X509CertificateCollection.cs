namespace Mono.Security.X509;

[DefaultMember("Item")]
public class X509CertificateCollection : CollectionBase, IEnumerable
{
	internal class X509CertificateEnumerator : IEnumerator
	{
		private IEnumerator enumerator; //Field offset: 0x10

		public X509Certificate Current
		{
			 get { } //Length: 149
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 73
		}

		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		public X509Certificate get_Current() { }

		public bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override bool System.Collections.IEnumerator.MoveNext() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}


	public X509Certificate Item
	{
		 get { } //Length: 152
	}

	public X509CertificateCollection() { }

	public int Add(X509Certificate value) { }

	public void AddRange(X509CertificateCollection value) { }

	private bool Compare(Byte[] array1, Byte[] array2) { }

	public bool Contains(X509Certificate value) { }

	public X509Certificate get_Item(int index) { }

	public X509CertificateEnumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public int IndexOf(X509Certificate value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

