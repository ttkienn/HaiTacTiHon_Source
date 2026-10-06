namespace System.Security.Claims;

public class Claim
{
	private string m_issuer; //Field offset: 0x10
	private string m_originalIssuer; //Field offset: 0x18
	private string m_type; //Field offset: 0x20
	private string m_value; //Field offset: 0x28
	private string m_valueType; //Field offset: 0x30
	private Byte[] m_userSerializationData; //Field offset: 0x38
	private Dictionary<String, String> m_properties; //Field offset: 0x40
	private object m_propertyLock; //Field offset: 0x48
	private ClaimsIdentity m_subject; //Field offset: 0x50

	public IDictionary<String, String> Properties
	{
		 get { } //Length: 259
	}

	public internal ClaimsIdentity Subject
	{
		 get { } //Length: 5
		internal set { } //Length: 13
	}

	public string Type
	{
		 get { } //Length: 5
	}

	public string Value
	{
		 get { } //Length: 5
	}

	public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	protected Claim(Claim other, ClaimsIdentity subject) { }

	public override Claim Clone(ClaimsIdentity identity) { }

	public IDictionary<String, String> get_Properties() { }

	public ClaimsIdentity get_Subject() { }

	public string get_Type() { }

	public string get_Value() { }

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

	internal void set_Subject(ClaimsIdentity value) { }

	public virtual string ToString() { }

}

