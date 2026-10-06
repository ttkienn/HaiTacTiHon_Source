namespace Mono.Security.X509;

[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
{
	private bool readOnly; //Field offset: 0x18

	public X509Extension Item
	{
		 get { } //Length: 508
	}

	public X509ExtensionCollection() { }

	public X509ExtensionCollection(ASN1 asn1) { }

	public X509Extension get_Item(string oid) { }

	public int IndexOf(string oid) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

