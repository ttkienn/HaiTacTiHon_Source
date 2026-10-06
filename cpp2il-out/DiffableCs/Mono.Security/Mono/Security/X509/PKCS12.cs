namespace Mono.Security.X509;

public class PKCS12 : ICloneable
{
	internal class DeriveBytes
	{
		private static Byte[] keyDiversifier; //Field offset: 0x0
		private static Byte[] ivDiversifier; //Field offset: 0x8
		private static Byte[] macDiversifier; //Field offset: 0x10
		private string _hashName; //Field offset: 0x10
		private int _iterations; //Field offset: 0x18
		private Byte[] _password; //Field offset: 0x20
		private Byte[] _salt; //Field offset: 0x28

		public string HashName
		{
			 set { } //Length: 13
		}

		public int IterationCount
		{
			 set { } //Length: 4
		}

		public Byte[] Password
		{
			 set { } //Length: 215
		}

		public Byte[] Salt
		{
			 set { } //Length: 200
		}

		private static DeriveBytes() { }

		public DeriveBytes() { }

		private void Adjust(Byte[] a, int aOff, Byte[] b) { }

		private Byte[] Derive(Byte[] diversifier, int n) { }

		public Byte[] DeriveIV(int size) { }

		public Byte[] DeriveKey(int size) { }

		public Byte[] DeriveMAC(int size) { }

		public void set_HashName(string value) { }

		public void set_IterationCount(int value) { }

		public void set_Password(Byte[] value) { }

		public void set_Salt(Byte[] value) { }

	}

	private static int password_max_length; //Field offset: 0x0
	private Byte[] _password; //Field offset: 0x10
	private ArrayList _keyBags; //Field offset: 0x18
	private ArrayList _secretBags; //Field offset: 0x20
	private X509CertificateCollection _certs; //Field offset: 0x28
	private bool _keyBagsChanged; //Field offset: 0x30
	private bool _secretBagsChanged; //Field offset: 0x31
	private bool _certsChanged; //Field offset: 0x32
	private int _iterations; //Field offset: 0x34
	private ArrayList _safeBags; //Field offset: 0x38
	private RandomNumberGenerator _rng; //Field offset: 0x40

	public X509CertificateCollection Certificates
	{
		 get { } //Length: 990
	}

	public int IterationCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ArrayList Keys
	{
		 get { } //Length: 1560
	}

	public static int MaximumPasswordLength
	{
		 get { } //Length: 77
	}

	public string Password
	{
		 set { } //Length: 445
	}

	internal RandomNumberGenerator RNG
	{
		internal get { } //Length: 59
	}

	private static PKCS12() { }

	public PKCS12(Byte[] data, string password) { }

	public PKCS12() { }

	public PKCS12(Byte[] data) { }

	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	public void AddCertificate(X509Certificate cert) { }

	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	private void AddPrivateKey(PrivateKeyInfo pki) { }

	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	public override object Clone() { }

	private bool Compare(Byte[] expected, Byte[] actual) { }

	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	private void Decode(Byte[] data) { }

	public Byte[] Decrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] encryptedData) { }

	public Byte[] Decrypt(EncryptedData ed) { }

	public Byte[] Encrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] data) { }

	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	protected virtual void Finalize() { }

	public X509CertificateCollection get_Certificates() { }

	public int get_IterationCount() { }

	public ArrayList get_Keys() { }

	public static int get_MaximumPasswordLength() { }

	internal RandomNumberGenerator get_RNG() { }

	public Byte[] GetBytes() { }

	private DSAParameters GetExistingParameters(out bool found) { }

	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Byte[] salt, int iterationCount) { }

	private Byte[] MAC(Byte[] password, Byte[] salt, int iterations, Byte[] data) { }

	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	private void ReadSafeBag(ASN1 safeBag) { }

	public void RemoveCertificate(X509Certificate cert) { }

	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	public void set_IterationCount(int value) { }

	public void set_Password(string value) { }

}

