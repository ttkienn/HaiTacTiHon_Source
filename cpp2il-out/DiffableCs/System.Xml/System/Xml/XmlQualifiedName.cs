namespace System.Xml;

public class XmlQualifiedName
{
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	public static readonly XmlQualifiedName Empty; //Field offset: 0x8
	private string name; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private int hash; //Field offset: 0x20

	public bool IsEmpty
	{
		 get { } //Length: 52
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	private static XmlQualifiedName() { }

	public XmlQualifiedName(string name, string ns) { }

	public XmlQualifiedName() { }

	public XmlQualifiedName(string name) { }

	internal void Atomize(XmlNameTable nameTable) { }

	internal XmlQualifiedName Clone() { }

	public virtual bool Equals(object other) { }

	public bool get_IsEmpty() { }

	public string get_Name() { }

	public string get_Namespace() { }

	public virtual int GetHashCode() { }

	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	internal void Init(string name, string ns) { }

	private static bool IsRandomizedHashingDisabled() { }

	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	internal void SetNamespace(string ns) { }

	public virtual string ToString() { }

	public static string ToString(string name, string ns) { }

	internal void Verify() { }

}

