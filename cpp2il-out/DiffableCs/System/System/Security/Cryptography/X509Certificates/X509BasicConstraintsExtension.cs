namespace System.Security.Cryptography.X509Certificates;

public sealed class X509BasicConstraintsExtension : X509Extension
{
	internal const string oid = "2.5.29.19"; //Field offset: 0x0
	internal const string friendlyName = "Basic Constraints"; //Field offset: 0x0
	private bool _certificateAuthority; //Field offset: 0x28
	private bool _hasPathLengthConstraint; //Field offset: 0x29
	private int _pathLengthConstraint; //Field offset: 0x2C
	private AsnDecodeStatus _status; //Field offset: 0x30

	public bool CertificateAuthority
	{
		 get { } //Length: 107
	}

	public bool HasPathLengthConstraint
	{
		 get { } //Length: 107
	}

	public int PathLengthConstraint
	{
		 get { } //Length: 106
	}

	public X509BasicConstraintsExtension() { }

	public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical) { }

	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(Byte[] extension) { }

	internal Byte[] Encode() { }

	public bool get_CertificateAuthority() { }

	public bool get_HasPathLengthConstraint() { }

	public int get_PathLengthConstraint() { }

	internal virtual string ToString(bool multiLine) { }

}

