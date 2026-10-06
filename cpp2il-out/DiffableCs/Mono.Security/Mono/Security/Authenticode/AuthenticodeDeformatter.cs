namespace Mono.Security.Authenticode;

public class AuthenticodeDeformatter : AuthenticodeBase
{
	private string filename; //Field offset: 0x40
	private Byte[] rawdata; //Field offset: 0x48
	private Byte[] hash; //Field offset: 0x50
	private X509CertificateCollection coll; //Field offset: 0x58
	private ASN1 signedHash; //Field offset: 0x60
	private DateTime timestamp; //Field offset: 0x68
	private X509Certificate signingCertificate; //Field offset: 0x70
	private int reason; //Field offset: 0x78
	private bool trustedRoot; //Field offset: 0x7C
	private bool trustedTimestampRoot; //Field offset: 0x7D
	private Byte[] entry; //Field offset: 0x80
	private X509Chain signerChain; //Field offset: 0x88
	private X509Chain timestampChain; //Field offset: 0x90

	public Byte[] RawData
	{
		 set { } //Length: 336
	}

	public X509Certificate SigningCertificate
	{
		 get { } //Length: 5
	}

	public AuthenticodeDeformatter() { }

	public AuthenticodeDeformatter(Byte[] rawData) { }

	private bool CheckSignature() { }

	private bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	public X509Certificate get_SigningCertificate() { }

	private void Reset() { }

	public void set_RawData(Byte[] value) { }

	private bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	private bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

}

