namespace System.Security.Cryptography;

public sealed class Oid
{
	private string _value; //Field offset: 0x10
	private string _friendlyName; //Field offset: 0x18
	private OidGroup _group; //Field offset: 0x20

	public string FriendlyName
	{
		 get { } //Length: 141
	}

	public string Value
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Oid() { }

	public Oid(string oid) { }

	public Oid(string value, string friendlyName) { }

	public Oid(Oid oid) { }

	private Oid(string value, string friendlyName, OidGroup group) { }

	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	public string get_FriendlyName() { }

	public string get_Value() { }

	public void set_Value(string value) { }

}

