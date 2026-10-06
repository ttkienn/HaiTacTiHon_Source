namespace System.Xml.Linq;

public sealed class XName : IEquatable<XName>, ISerializable
{
	private XNamespace _ns; //Field offset: 0x10
	private string _localName; //Field offset: 0x18
	private int _hashCode; //Field offset: 0x20

	public string LocalName
	{
		 get { } //Length: 5
	}

	public XNamespace Namespace
	{
		 get { } //Length: 5
	}

	public string NamespaceName
	{
		 get { } //Length: 27
	}

	internal XName(XNamespace ns, string localName) { }

	internal XName() { }

	public virtual bool Equals(object obj) { }

	public static XName Get(string expandedName) { }

	public static XName Get(string localName, string namespaceName) { }

	public string get_LocalName() { }

	public XNamespace get_Namespace() { }

	public string get_NamespaceName() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(XName left, XName right) { }

	[CLSCompliant(False)]
	public static XName op_Implicit(string expandedName) { }

	private override bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

