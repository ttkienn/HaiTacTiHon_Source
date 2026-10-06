namespace System.Net;

[ComVisible(True)]
[DefaultMember("Item")]
public class WebHeaderCollection : NameValueCollection, ISerializable
{
	private enum RfcChar
	{
		High = 0,
		Reg = 1,
		Ctl = 2,
		CR = 3,
		LF = 4,
		WS = 5,
		Colon = 6,
		Delim = 7,
	}

	private static readonly HeaderInfoTable HInfo; //Field offset: 0x0
	private static readonly String[] s_CommonHeaderNames; //Field offset: 0x8
	private static readonly SByte[] s_CommonHeaderHints; //Field offset: 0x10
	private static readonly Char[] HttpTrimCharacters; //Field offset: 0x18
	private static RfcChar[] RfcCharMap; //Field offset: 0x20
	private String[] m_CommonHeaders; //Field offset: 0x60
	private int m_NumCommonHeaders; //Field offset: 0x68
	private NameValueCollection m_InnerCollection; //Field offset: 0x70
	private WebHeaderCollectionType m_Type; //Field offset: 0x78

	private bool AllowHttpRequestHeader
	{
		private get { } //Length: 39
	}

	public virtual int Count
	{
		 get { } //Length: 59
	}

	private NameValueCollection InnerCollection
	{
		private get { } //Length: 177
	}

	private static WebHeaderCollection() { }

	protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public WebHeaderCollection() { }

	internal WebHeaderCollection(WebHeaderCollectionType type) { }

	public void Add(string header) { }

	public virtual void Add(string name, string value) { }

	internal void AddInternal(string name, string value) { }

	internal static bool AllowMultiValues(string name) { }

	internal void ChangeInternal(string name, string value) { }

	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	internal static bool ContainsNonAsciiChars(string token) { }

	public virtual string Get(string name) { }

	public virtual string Get(int index) { }

	private bool get_AllowHttpRequestHeader() { }

	public virtual int get_Count() { }

	private NameValueCollection get_InnerCollection() { }

	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual string GetKey(int index) { }

	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual String[] GetValues(string header) { }

	private void NormalizeCommonHeaders() { }

	public virtual void OnDeserialization(object sender) { }

	public void Remove(HttpRequestHeader header) { }

	public virtual void Remove(string name) { }

	internal void RemoveInternal(string name) { }

	public virtual void Set(string name, string value) { }

	internal void SetInternal(string name, string value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void ThrowOnRestrictedHeader(string headerName) { }

	public virtual string ToString() { }

}

