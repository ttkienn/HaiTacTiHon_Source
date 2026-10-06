namespace Mono.Security.X509;

public sealed class X501
{
	private static Byte[] countryName; //Field offset: 0x0
	private static Byte[] organizationName; //Field offset: 0x8
	private static Byte[] organizationalUnitName; //Field offset: 0x10
	private static Byte[] commonName; //Field offset: 0x18
	private static Byte[] localityName; //Field offset: 0x20
	private static Byte[] stateOrProvinceName; //Field offset: 0x28
	private static Byte[] streetAddress; //Field offset: 0x30
	private static Byte[] serialNumber; //Field offset: 0x38
	private static Byte[] domainComponent; //Field offset: 0x40
	private static Byte[] userid; //Field offset: 0x48
	private static Byte[] email; //Field offset: 0x50
	private static Byte[] dnQualifier; //Field offset: 0x58
	private static Byte[] title; //Field offset: 0x60
	private static Byte[] surname; //Field offset: 0x68
	private static Byte[] givenName; //Field offset: 0x70
	private static Byte[] initial; //Field offset: 0x78

	private static X501() { }

	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	public static ASN1 FromString(string rdn) { }

	private static AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	private static bool IsHex(char c) { }

	private static bool IsOid(string oid) { }

	private static AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	private static string ReadHex(string value, ref int pos) { }

	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	private static string ReadValue(string value, ref int pos) { }

	public static string ToString(ASN1 seq) { }

	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

}

