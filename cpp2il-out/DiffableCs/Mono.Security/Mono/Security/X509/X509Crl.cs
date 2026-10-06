namespace Mono.Security.X509;

[DefaultMember("Item")]
public class X509Crl
{
	internal class X509CrlEntry
	{
		private Byte[] sn; //Field offset: 0x10
		private DateTime revocationDate; //Field offset: 0x18
		private X509ExtensionCollection extensions; //Field offset: 0x20

		public X509ExtensionCollection Extensions
		{
			 get { } //Length: 5
		}

		public DateTime RevocationDate
		{
			 get { } //Length: 5
		}

		public Byte[] SerialNumber
		{
			 get { } //Length: 119
		}

		internal X509CrlEntry(ASN1 entry) { }

		public X509ExtensionCollection get_Extensions() { }

		public DateTime get_RevocationDate() { }

		public Byte[] get_SerialNumber() { }

	}

	private string issuer; //Field offset: 0x10
	private byte version; //Field offset: 0x18
	private DateTime thisUpdate; //Field offset: 0x20
	private DateTime nextUpdate; //Field offset: 0x28
	private ArrayList entries; //Field offset: 0x30
	private string signatureOID; //Field offset: 0x38
	private Byte[] signature; //Field offset: 0x40
	private X509ExtensionCollection extensions; //Field offset: 0x48
	private Byte[] encoded; //Field offset: 0x50
	private Byte[] hash_value; //Field offset: 0x58

	public X509ExtensionCollection Extensions
	{
		 get { } //Length: 5
	}

	public Byte[] Hash
	{
		 get { } //Length: 375
	}

	public string IssuerName
	{
		 get { } //Length: 5
	}

	public DateTime NextUpdate
	{
		 get { } //Length: 5
	}

	public X509Crl(Byte[] crl) { }

	private bool Compare(Byte[] array1, Byte[] array2) { }

	public X509ExtensionCollection get_Extensions() { }

	public Byte[] get_Hash() { }

	public string get_IssuerName() { }

	public DateTime get_NextUpdate() { }

	public X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	public X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	private void Parse(Byte[] crl) { }

	internal bool VerifySignature(DSA dsa) { }

	internal bool VerifySignature(RSA rsa) { }

	public bool VerifySignature(AsymmetricAlgorithm aa) { }

}

