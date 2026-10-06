namespace Mono.Security.X509;

public class X520
{
	internal abstract class AttributeTypeAndValue
	{
		private string oid; //Field offset: 0x10
		private string attrValue; //Field offset: 0x18
		private int upperBound; //Field offset: 0x20
		private byte encoding; //Field offset: 0x24

		public string Value
		{
			 set { } //Length: 191
		}

		protected AttributeTypeAndValue(string oid, int upperBound) { }

		protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) { }

		internal ASN1 GetASN1(byte encoding) { }

		internal ASN1 GetASN1() { }

		private byte SelectBestEncoding() { }

		public void set_Value(string value) { }

	}

	internal class CommonName : AttributeTypeAndValue
	{

		public CommonName() { }

	}

	internal class CountryName : AttributeTypeAndValue
	{

		public CountryName() { }

	}

	internal class DnQualifier : AttributeTypeAndValue
	{

		public DnQualifier() { }

	}

	internal class DomainComponent : AttributeTypeAndValue
	{

		public DomainComponent() { }

	}

	internal class EmailAddress : AttributeTypeAndValue
	{

		public EmailAddress() { }

	}

	internal class GivenName : AttributeTypeAndValue
	{

		public GivenName() { }

	}

	internal class Initial : AttributeTypeAndValue
	{

		public Initial() { }

	}

	internal class LocalityName : AttributeTypeAndValue
	{

		public LocalityName() { }

	}

	internal class Oid : AttributeTypeAndValue
	{

		public Oid(string oid) { }

	}

	internal class OrganizationalUnitName : AttributeTypeAndValue
	{

		public OrganizationalUnitName() { }

	}

	internal class OrganizationName : AttributeTypeAndValue
	{

		public OrganizationName() { }

	}

	internal class SerialNumber : AttributeTypeAndValue
	{

		public SerialNumber() { }

	}

	internal class StateOrProvinceName : AttributeTypeAndValue
	{

		public StateOrProvinceName() { }

	}

	internal class Surname : AttributeTypeAndValue
	{

		public Surname() { }

	}

	internal class Title : AttributeTypeAndValue
	{

		public Title() { }

	}

	internal class UserId : AttributeTypeAndValue
	{

		public UserId() { }

	}


}

